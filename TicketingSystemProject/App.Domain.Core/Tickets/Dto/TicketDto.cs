using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.Tickets.Dto;

public class TicketDto
{
    public int Id { get; set; }
    [Display(Name = "موضوع")]
    public string Subject { get; set; }

    [Display(Name = "توضیحات")]
    public string Description { get; set; }

    [Display(Name = "زمان ثبت")]
    public string SubmitAt { get; set; }
    public int UserId { get; set; }

    [Display(Name = "ثبت توسط:")]
    public string SubmitBy { get; set; }

    public int CategoyId { get; set; }
    [Display(Name = "دسته بندی")]
    public string CategoryTitle { get; set; }
    public int PriorityId { get; set; }
    [Display(Name = "اولویت")]
    public string PriorityTitle { get; set; }
    public ICollection<TicketHistoryDto> TicketHistories { get; set; }
}
