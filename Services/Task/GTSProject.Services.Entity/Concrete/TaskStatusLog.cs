﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskStatusLog // Talep durum kayıtlarını tutar.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int AssigneeId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
