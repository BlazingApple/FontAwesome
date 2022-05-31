namespace BlazingApple.FontAwesome.Models
{
    /// <summary>A FontAwesome icon.</summary>
    public class FontAwesomeIcon
    {
        /// <summary>The string identifier of an icon.</summary>
        /// <example>"coffee-pot"</example>
        public string? Id { get; set; }

        /// <summary>The human readable description of the icon.</summary>
        public string? Label { get; set; }

        /// <summary>The styles available to this icon (by membership).</summary>
        public Memberships? Membership { get; set; }

        /// <summary>Get the code "class" used in HTML</summary>
        /// <param name="style">The style of icon desired.</param>
        /// <returns>The details for the icon required for rendering.</returns>
        public string GetCode(string style = "solid")
        {
            if (Membership?.Free?.Contains(style) == false && !Membership?.Paid?.Contains(style) == false)
                return "";
            string prefix = GetPrefixForStyle(style);

            return $"{prefix} fa-{Id}";
        }

        /// <inheritdoc />
        public override string ToString()
        {
            if (Membership is not null && Membership.Free?.Count >= 1)
                return GetCode(Membership.Free[0]);
            else
                return "";
        }

        private string GetPrefixForStyle(string style)
        {
            return style switch
            {
                "solid" => "fas",
                "regular" => "far",
                "light" => "fal",
                "duotone" => "fad",
                "brands" => "fab",
                _ => "fas"
            };
        }
    }
}
