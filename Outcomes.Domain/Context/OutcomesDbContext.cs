// Copyright Naked Objects Group Ltd, 45 Station Road, Henley on Thames, UK, RG9 1AT
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0.
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Data.Entity;

namespace Outcomes.Domain.Context {
    internal class Initializer : DropCreateDatabaseAlways<OutcomesDbContext> {
        protected override void Seed(OutcomesDbContext context) {
            var h1 = new Hospital {Name = "St Elsewhere"};
            var h2 = new Hospital {Name = "St Somewhere"};

            context.Hospitals.Add(h1);
            context.Hospitals.Add(h2);

            var s1 = new Surgeon {Name = "Mr Luke"};
            var s2 = new Surgeon {Name = "Mr Mark"};

            context.Surgeons.Add(s1);
            context.Surgeons.Add(s2);

            var c1 = new Complication {Name = "Infection"};

            context.Complications.Add(c1);

            var p1 = new ProcedureType {Name = "Neck Dissection", Complications = {c1}};

            context.ProcedureTypes.Add(p1);

            var ot1 = new OperationType {Name = "Oncology", ProcedureTypes = {p1}};
            var ot2 = new OperationType {Name = "TMJ"};
            var ot3 = new OperationType {Name = "Dental Alviola"};

            context.OperationTypes.Add(ot1);
            context.OperationTypes.Add(ot2);
            context.OperationTypes.Add(ot3);
        }
    }

    public class OutcomesDbContext : DbContext {
        public OutcomesDbContext(string dbName) : base(dbName) {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Surgeon> Surgeons { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Complication> Complications { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<ProcedureType> ProcedureTypes { get; set; }
    }
}