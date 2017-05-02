// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Q11_QUERY_RESULT_CLUSTER (GroupMap) - 
    /// </summary>
    public class RSP_Q11_QUERY_RESULT_CLUSTERMap :
        HL7TemplateMap<RSP_Q11_QUERY_RESULT_CLUSTER>
    {
        public RSP_Q11_QUERY_RESULT_CLUSTERMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.LOC, 1, x => x.Required = true);
            Segments(x => x.LCH, 2);
            Segments(x => x.LRL, 3);
            Groups(x => x.MfLocDept, 4, x => x.Required = true);
        }
    }
}