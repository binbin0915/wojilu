/*
 * Copyright 2010 www.wojilu.com
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace wojilu.Config {

    /// <summary>
    /// 配置项
    /// </summary>
    public interface ISetting {

        int Id { get; set; }

        String DataType { get; set; }

        String Name { get; set; }
        String Description { get; set; }

        // 格式json
        String Options { get; set; }  

        String SettingValue { get; set; }


        String ValueString { get; }
        int ValueInt { get; }
        Boolean ValueBool { get; }
        DateTime ValueTime { get; }

    }
}

