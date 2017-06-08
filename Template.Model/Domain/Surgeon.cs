// Copyright Naked Objects Group Ltd, 45 Station Road, Henley on Thames, UK, RG9 1AT
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0.
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using NakedObjects;

namespace Template.Model {
    public class Surgeon {
        //All persisted properties on a domain object must be 'virtual'

        [NakedObjectsIgnore] //Indicates that this property will never be seen in the UI
        public virtual int Id { get; set; }

        [Title] //This property will be used for the object's title at the top of the view and in a link
        public virtual string Name { get; set; }
    }
}