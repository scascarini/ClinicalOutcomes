// Copyright Naked Objects Group Ltd, 45 Station Road, Henley on Thames, UK, RG9 1AT
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0.
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Data.Entity;
using Template.Model;

namespace Template.DataBase {
   

    public class OutcomesDbContext : DbContext {
        public OutcomesDbContext(string dbName, IDatabaseInitializer<OutcomesDbContext> initializer) : base(dbName) {
            Database.SetInitializer(initializer);
        }

        public DbSet<Surgeon> Surgeons { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Complication> Complications { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<ProcedureType> ProcedureTypes { get; set; }
    }
}