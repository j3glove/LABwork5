using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication5.Models
{
    public class AirplaneOwner
    {
        [DisplayName("ID")]
        public int AeroClubId { get; set; }

        [DisplayName("Фамилия")]
        public string Name { get; set; }

        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DisplayName("Уровень пилотирования")]
        public string Type { get; set; }

        [DisplayName("Количество самолетов")]
        public int NumberOfPlanes { get; set; }

        [DisplayName("Место жительства")]
        public string Location { get; set; }
    }
}
