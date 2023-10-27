﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.ORM.Entity
{
    [Table("person")]
    public class Person
    {
  

        [Column("id")]
        public long Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("description")]
        public string Description { get; set; }



    }
}
