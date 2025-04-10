using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CoreBusiness.Entidades
{
    public class Observacao
    {
        [Required]
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
        public string text {  get; set; }

        public Observacao() { }

        public Observacao(string text)
        {
            Id = Guid.NewGuid();
            this.text = text;
        }
    }
}
