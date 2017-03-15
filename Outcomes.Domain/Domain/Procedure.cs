
using System.Collections.Generic;
using NakedObjects;

namespace Outcomes.Domain {
    public class Procedure {
        [NakedObjectsIgnore] //Indicates that this property will never be seen in the UI
        public virtual int Id { get; set; }

        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual SideType Side { get; set; }

        public virtual ProcedureType Type { get; set; }

        public virtual Surgeon ResponsibleSurgeon { get; set; }

        public virtual Surgeon OperatingSurgeon { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual IList<Complication> Complications { get; set; } = new List<Complication>();
    }
}