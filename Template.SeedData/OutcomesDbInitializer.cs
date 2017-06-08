using System.Data.Entity;
using Template.DataBase;
using Template.Model;

namespace Template.SeedData
{
    public class OutcomesDbInitializer : DropCreateDatabaseIfModelChanges<OutcomesDbContext> {
        protected override void Seed(OutcomesDbContext context) {
            var h1 = new Hospital { Name = "St Elsewhere" };
            var h2 = new Hospital { Name = "St Somewhere" };

            context.Hospitals.Add(h1);
            context.Hospitals.Add(h2);

            var s1 = new Surgeon { Name = "Mr Luke" };
            var s2 = new Surgeon { Name = "Mr Mark" };

            context.Surgeons.Add(s1);
            context.Surgeons.Add(s2);

            var c1 = new Complication { Name = "Infection" };

            context.Complications.Add(c1);

            var p1 = new ProcedureType { Name = "Neck Dissection", Complications = { c1 } };

            context.ProcedureTypes.Add(p1);

            var ot1 = new OperationType { Name = "Oncology", ProcedureTypes = { p1 } };
            var ot2 = new OperationType { Name = "TMJ" };
            var ot3 = new OperationType { Name = "Dental Alviola" };

            context.OperationTypes.Add(ot1);
            context.OperationTypes.Add(ot2);
            context.OperationTypes.Add(ot3);
        }
    }
}
