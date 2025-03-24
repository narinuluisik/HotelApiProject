﻿using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Servis ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı  giriniz")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
