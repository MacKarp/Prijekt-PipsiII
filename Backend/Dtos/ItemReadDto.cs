﻿using Backend.Models;

namespace Backend.Dtos
{
    public class ItemReadDto
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int IdCategory { get; set; }
    }
}