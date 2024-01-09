using System.ComponentModel.DataAnnotations;

namespace S25_AspNetCore_ModelValidation.Models.Entities;

public class Product
{
    [Display(Name = "شناسه")]
    public int Id { get; set; }

    [Required(ErrorMessage = "نام کالا اجباری می باشد.")]
    [Display(Name = "نام کالا")]
    public string Name { get; set; }

    //[DataType(DataType.EmailAddress)]
    //[AllowedValues]
    //Compare
    [MaxLength(10, ErrorMessage = "تعداد حروف برند نباید بیشتر از 10 باشد")]
    [MinLength(5, ErrorMessage = "تعداد حروف برند نباید کمتر از 5 باشد")]
    public string Brand { get; set; }

    //[DataType(DataType.,ErrorMessage = "فیلد مبلغ عددی است")]
    [Required(ErrorMessage = "مبلغ اجباری می باشد.")]
    [Display(Name = "مبلغ")]
    [Range(1000_000,1000000000000000, ErrorMessage = "دوست عزیز مبلغ ورودی باید بالای 1 م ت باشد")]
    public int Price { get; set; }
}