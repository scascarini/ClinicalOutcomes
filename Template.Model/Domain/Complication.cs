
using NakedObjects;

namespace Template.Model {
    [Bounded]
    public class Complication {
        [NakedObjectsIgnore] //Indicates that this property will never be seen in the UI
        public virtual int Id { get; set; }

        [Title]
        public virtual string Name { get; set; }
    }
}