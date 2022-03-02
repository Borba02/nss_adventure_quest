using System;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }

        //This method retunrs a string to describe the hat's shininess level
        public string GetShininessDescription() 
        {
            string description = "blinding";
            if (ShininessLevel < 2) {
                description = "dull";
            } else if (ShininessLevel >= 2 && ShininessLevel <= 5) {
                description = "noticeable";
            } else if (ShininessLevel >= 6 && ShininessLevel <= 9) {
                description = "bright";
            }
            return description;
        }
    }
}