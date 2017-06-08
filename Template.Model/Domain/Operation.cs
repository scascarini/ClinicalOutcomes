using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NakedObjects;

namespace Template.Model {
    public class Operation {
        [NakedObjectsIgnore] //Indicates that this property will never be seen in the UI
        public virtual int Id { get; set; }
        public virtual Surgeon Anaethetist { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual IList<Procedure> Procedures { get; set; } = new List<Procedure>();

        public virtual DateTime AdmissionDate { get; set; }
        public virtual DateTime DischargeDate { get; set; }

        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }

    }
}
