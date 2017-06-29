// Copyright 2007-2016 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Machete.Cursors.Payloads
{
    /// <summary>
    /// The context properties
    /// </summary>
    public interface IPayloadCache :
        IReadOnlyPayloadCollection
    {
        /// <summary>
        /// Return an existing or create a new property
        /// </summary>
        /// <param name="payloadFactory"></param>
        /// <returns></returns>
        T GetOrAddPayload<T>(PayloadFactory<T> payloadFactory)
            where T : class;

        T AddOrUpdatePayload<T>(PayloadFactory<T> addFactory, UpdatePayloadFactory<T> payloadFactory)
            where T : class;
    }
}