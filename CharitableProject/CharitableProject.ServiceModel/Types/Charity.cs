using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace CharitableProject.ServiceModel.Types
{
    public class Charity
    {
        [AutoIncrement]
        public int Id { get; set; }

        [Index]
        public string ABN { get; set; }
        [Index]
        public string Charity_Legal_Name { get; set; }
        public string Other_Organisation_Names { get; set; }
        public string Operating_Countries { get; set; }
        public string Address_Type { get; set; }
        public string Address_Line_1 { get; set; }
        public string Address_Line_2 { get; set; }
        public string Address_Line_3 { get; set; }
        public string Town_City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Charity_Website { get; set; }
        public string Registration_Date { get; set; }
        public string Date_Organisation_Established { get; set; }
        public string Charity_Size { get; set; }
        public string Number_of_Responsible_Persons { get; set; }
        public string Financial_Year_End { get; set; }
        public string Operates_in_ACT { get; set; }
        public string Operates_in_NSW { get; set; }
        public string Operates_in_NT { get; set; }
        public string Operates_in_QLD { get; set; }
        public string Operates_in_SA { get; set; }
        public string Operates_in_TAS { get; set; }
        public string Operates_in_VIC { get; set; }
        public string Operates_in_WA { get; set; }
        public string PBI { get; set; }
        public string HPC { get; set; }
        public string Preventing_or_relieving_suffering_of_animals { get; set; }
        public string Advancing_Culture { get; set; }
        public string Advancing_Education { get; set; }
        public string Advancing_Health { get; set; }
        public string Promote_or_oppose_a_change_to_law__government_poll_or_prac { get; set; }
        public string Advancing_natual_environment { get; set; }
        public string Promoting_or_protecting_human_rights { get; set; }
        public string Purposes_beneficial_to_ther_general_public_and_other_analogous { get; set; }
        public string Promoting_reconciliation__mutual_respect_and_tolerance { get; set; }
        public string Advancing_Religion { get; set; }
        public string Advancing_social_or_public_welfare { get; set; }
        public string Advancing_security_or_safety_of_Australia_or_Australian_public { get; set; }
        public string Another_purpose_beneficial_to_the_community { get; set; }
        public string Aboriginal_or_TSI { get; set; }
        public string Aged_Persons { get; set; }
        public string Children { get; set; }
        public string Communities_Overseas { get; set; }
        public string Ethnic_Groups { get; set; }
        public string Gay__Lesbian__Bisexual { get; set; }
        public string General_Community_in_Australia { get; set; }
        public string Men { get; set; }
        public string Migrants__Refugees_or_Asylum_Seekers { get; set; }
        public string Pre_Post_Release_Offenders { get; set; }
        public string People_with_Chronic_Illness { get; set; }
        public string People_with_Disabilities { get; set; }
        public string People_at_risk_of_homelessness { get; set; }
        public string Unemployed_Persons { get; set; }
        public string Veterans_or_their_families { get; set; }
        public string Victims_of_crime { get; set; }
        public string Victims_of_Disasters { get; set; }
        public string Women { get; set; }
        public string Youth { get; set; }
    }
}
