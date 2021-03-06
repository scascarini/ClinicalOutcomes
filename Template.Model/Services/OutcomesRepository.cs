﻿// Copyright Naked Objects Group Ltd, 45 Station Road, Henley on Thames, UK, RG9 1AT
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0.
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Linq;
using NakedObjects;

namespace Template.Model.Services {
    public class OutcomesRepository {
        #region Injected Services

        //An implementation of this interface is injected automatically by the framework
        public IDomainObjectContainer Container { set; protected get; }

        #endregion

        public Surgeon CreateNewSurgeon() {
            return Container.NewTransientInstance<Surgeon>();
        }

        public Procedure CreateNewProcedure() {
            return Container.NewTransientInstance<Procedure>();
        }

        public IQueryable<Surgeon> AllSurgeons() {
            return Container.Instances<Surgeon>();
        }

        public IQueryable<Patient> AllPatients() {
            return Container.Instances<Patient>();
        }

        public IQueryable<Procedure> AllProcedures() {
            return Container.Instances<Procedure>();
        }

        public IQueryable<Surgeon> FindSurgeonByName(string name) {
            return AllSurgeons().Where(c => c.Name.ToUpper().Contains(name.ToUpper()));
        }
    }
}