﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskType // Talep tiplerini içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
