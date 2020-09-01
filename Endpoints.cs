using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UselessAPI.NET
{
    public static class UselessEndpoint
    {
        /// <summary>
        /// Returns a MemoryStream for a door image.
        /// </summary>
        public static MemoryStream Door(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"door?text={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a baby image.
        /// </summary>
        public static MemoryStream Baby(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"baby?text={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a grayscale image.
        /// </summary>
        public static MemoryStream Grayscale(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"grayscale?text={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a random colour.
        /// </summary>
        public static MemoryStream RandomColor()
        {
            return RequestFunctions.ImageRequest($"color?random=true");
        }

        /// <summary>
        /// Returns a MemoryStream for a hex colour.
        /// </summary>
        public static MemoryStream Color(string hex)
        {
            return RequestFunctions.ImageRequest($"color?hex={hex}");
        }

        /// <summary>
        /// Returns a MemoryStream for a rotated image.
        /// </summary>
        public static MemoryStream Rotate(string imageUrl, string angle)
        {
            return RequestFunctions.ImageRequest($"rotate?image={imageUrl}&angle={angle}");
        }

        /// <summary>
        /// F to pay respects.
        /// </summary>
        public static MemoryStream Respects(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"respects?image={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for an art on the wall image.
        /// </summary>
        public static MemoryStream ChatRoulette(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"chatroulette?image={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a wolverine in bed image.
        /// </summary>
        public static MemoryStream Wolverine(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"wolverine?image={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a this is disgusting generator.
        /// </summary>
        public static MemoryStream Disgusting(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"disgusting?image={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a Phineas and Ferb TV image.
        /// </summary>
        public static MemoryStream PhineasAndFerbTV(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"ferbtv?image={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a tinder match image.
        /// </summary>
        public static MemoryStream TinderMatch(string image1, string image2)
        {
            return RequestFunctions.ImageRequest($"tinder?image1={image1}&image2={image2}");
        }

        /// <summary>
        /// Returns a MemoryStream for a text to image generator.
        /// </summary>
        public static MemoryStream TextToImage(string text)
        {
            return RequestFunctions.ImageRequest($"texttoimage?text={text}");
        }

        /// <summary>
        /// TEMPORARILY DISABLED DUE TO BUG.
        /// </summary>
        public static MemoryStream ServerCard()
        {
            return RequestFunctions.ImageRequest($"texttoimage?text=Currently Disabled.");
        }

        /// <summary>
        /// Returns a MemoryStream for a triggered image generator.
        /// </summary>
        public static MemoryStream Triggered(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"triggered?image={imageUrl}&increment=4");
        }

        /// <summary>
        /// Returns a MemoryStream for a primitive technology image filter.
        /// </summary>
        public static MemoryStream Primitive(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"primitive?image={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a blur image filter.
        /// </summary>
        public static MemoryStream Blur(string imageUrl)
        {
            return RequestFunctions.ImageRequest($"blur?image={imageUrl}");
        }

        /// <summary>
        /// Returns a MemoryStream for a glitch image filter on avatar.
        /// </summary>
        public static MemoryStream Glitch(string avatarURL)
        {
            return RequestFunctions.ImageRequest($"glitch?image={avatarURL}");
        }

        /// <summary>
        /// Returns a MemoryStream for a minecraft disconnected screen.
        /// </summary>
        public static MemoryStream Disconnected(string text)
        {
            return RequestFunctions.ImageRequest($"disconnected?text={text}");
        }

        /// <summary>
        /// Returns a MemoryStream for a flipped image (GIF).
        /// </summary>
        public static MemoryStream Flip(string imageURL)
        {
            return RequestFunctions.ImageRequest($"flip?image={imageURL}");
        }

        /// <summary>
        /// Returns a MemoryStream for a "I have failed you" image (probably for simps).
        /// </summary>
        public static MemoryStream Failed(string imageURL)
        {
            return RequestFunctions.ImageRequest($"failed?image={imageURL}");
        }

        /// <summary>
        /// Returns a MemoryStream for a captcha image generator.
        /// </summary>
        public static MemoryStream Captcha(string text)
        {
            return RequestFunctions.ImageRequest($"captcha?text={text}");
        }

        /// <summary>
        /// Returns a MemoryStream for a spongebob burn image.
        /// </summary>
        public static MemoryStream Burn(string imageURL)
        {
            return RequestFunctions.ImageRequest($"burn?image={imageURL}");
        }

        /// <summary>
        /// UselessAPI ratelimit is 5 requests per second.
        /// </summary>
        public static string RateLimit()
        {
            return "5 per second";
        }
    }
}
