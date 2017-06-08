using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NakedObjects;

namespace Template.Model {
    public class Hospital {
        [NakedObjectsIgnore] //Indicates that this property will never be seen in the UI
        public virtual int Id { get; set; }

        [Title]
        public virtual string Name { get; set; }
    }
}
