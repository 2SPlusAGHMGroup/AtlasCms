using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModels
{
    /// <summary>
    /// اطلاعات مربوط به مناطق شامل ، شهر ، کشور ، منطقه در این مدل قرار خواهد گرفت
    /// </summary>
    [Table("Country")]
    public class Country
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("Id", Order = 0)]
        public Guid Id { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        [Column(TypeName="varchar")]
        public string LatinName { get; set; }
        public Country Parent { get; set; }
        [NotMapped]
        public string NotMap { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public Country(int _code, string _name, string _latinName = null, Country _parent = null)
        {
            this.Code = _code;
            this.Name = _name;
            this.Parent = _parent;
            this.LatinName = _latinName;
        }
    }
}
