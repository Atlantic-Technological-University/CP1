// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace ListExample
{
    public class Module
    {
        // Setting the Module code and name to empty to address CS8618
        public string ModuleCode { get; set; } = string.Empty;
        public string ModuleName { get; set; } = string.Empty;
        public float ModuleMark { get; set; }
        public int ModuleYear { get; set; }

        public Module(string moduleCode, string moduleName, float moduleMark, int moduleYear)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleMark = moduleMark;
            ModuleYear = moduleYear;
        }

        public override string ToString()
        {
            return "ModuleCode: " + ModuleCode+ "    ModuleName: " + ModuleName + "    ModuleMark: " + ModuleMark + "    ModuleYear: " + ModuleYear;
        }
    }
}
