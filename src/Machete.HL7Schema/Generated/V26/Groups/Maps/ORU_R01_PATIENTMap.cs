// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R01_PATIENT (GroupMap) - 
    /// </summary>
    public class ORU_R01_PATIENTMap :
        HL7TemplateMap<ORU_R01_PATIENT>
    {
        public ORU_R01_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segments(x => x.NTE, 2);
            Segments(x => x.NK1, 3);
            Segments(x => x.OBX, 4);
            Group(x => x.Visit, 5);
        }
    }
}