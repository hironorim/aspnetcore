using System.ComponentModel.DataAnnotations;

namespace aspnetcore.Models
{
    public enum ConvertType
    {
        [Display(Name = "URLエンコード")]
        UrlEncode,

        [Display(Name = "URLデコード")]
        UrlDecode,

        [Display(Name = "HTMLエンコード")]
        HtmlEncode,

        [Display(Name = "HTMLデコード")]
        HtmlDocode
    }

    public class ToolViewModel
    {
        [Display(Name = "変換テキスト")]
        public string Value { get; set; }

        [Display(Name = "変換方法")]
        public ConvertType ConvertType { get; set; }

        [Display(Name = "変換結果")]
        public string Result { get; set; }
    }
}
