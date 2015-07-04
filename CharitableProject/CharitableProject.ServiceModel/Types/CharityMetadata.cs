using ServiceStack.DataAnnotations;

namespace CharitableProject.ServiceModel.Types
{
    public class CharityMetadata
    {
        [AutoIncrement]
        public int Id { get; set; }

        [Index]
        public string ABN { get; set; }
        [Index]
        public string Charity_Name { get; set; }
        public string Other_Organisation_Names { get; set; }
        public string Address_Type { get; set; }
        public string Address_Line_1 { get; set; }
        public string Address_Line_2 { get; set; }
        public string Address_Line_3 { get; set; }
        public string Town_City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Operating_Countries { get; set; }
        public string Operates_in_ACT { get; set; }
        public string Operates_in_NSW { get; set; }
        public string Operates_in_NT { get; set; }
        public string Operates_in_QLD { get; set; }
        public string Operates_in_SA { get; set; }
        public string Operates_in_TAS { get; set; }
        public string Operates_in_VIC { get; set; }
        public string Operates_in_WA { get; set; }
        public string Relief_of_poverty__sickness_or_the_needs_of_the_aged { get; set; }
        public string The_advancement_of_education { get; set; }
        public string The_advancement_of_religion { get; set; }
        public string The_provision_of_child_care_services { get; set; }
        public string Other_purposes_beneficial_to_the_community { get; set; }
        public string BASIC_RELIGIOUS { get; set; }
        public string Conducted_Activities { get; set; }
        public string Main_Activity { get; set; }
        public string Animal_Protection { get; set; }
        public string Aged_Care_Activities { get; set; }
        public string Civic_and_advocacy_activities { get; set; }
        public string Culture_and_arts { get; set; }
        public string Economic__social_and_community_development { get; set; }
        public string Emergency_Relief { get; set; }
        public string Employment_and_training { get; set; }
        public string Environmental_activities { get; set; }
        public string Grant_making_activities { get; set; }
        public string Higher_education { get; set; }
        public string Hospital_services_and_rehabilitation_activities { get; set; }
        public string Housing_activities { get; set; }
        public string Income_support_and_maintenance { get; set; }
        public string International_activities { get; set; }
        public string Law_and_legal_services { get; set; }
        public string Mental_health_and_crisis_intervention { get; set; }
        public string Political_activities { get; set; }
        public string Primary_and_secondary_education { get; set; }
        public string Religious_activities { get; set; }
        public string Research { get; set; }
        public string Social_services { get; set; }
        public string Sports { get; set; }
        public string Other_Educations { get; set; }
        public string Other_health_service_delivery { get; set; }
        public string Other_recreation_and_social_club_activity { get; set; }
        public string Other { get; set; }
        public string Other_activity_description { get; set; }
        public string How_purposes_were_pursued { get; set; }
        public string Will_purposes_change_in_the_next_financial_year_ { get; set; }
        public string Description_of_purposes_change__if_applicable_ { get; set; }
        public string Charity_Size { get; set; }
        public string Financial_Year_End { get; set; }
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
        public string Other_charities { get; set; }
        public string Other_beneficiaries_not_listed { get; set; }
        public string Other_beneficiaries_description { get; set; }
        public string Staff___Full_time { get; set; }
        public string Staff___Part_time { get; set; }
        public string Staff___Volunteers { get; set; }
        public string Other_Commonwealth_Agency_Reporting_Obligations { get; set; }
        public string OTHER_Regulator_details__if_selected_ { get; set; }
        public string Reporting_Program_details { get; set; }
        public string Reporting_Obligations___ACT { get; set; }
        public string Reporting_Obligations___NSW { get; set; }
        public string Reporting_Obligations___NT { get; set; }
        public string Reporting_Obligations___QLD { get; set; }
        public string Reporting_Obligations___SA { get; set; }
        public string Reporting_Obligations___TAS { get; set; }
        public string Reporting_Obligations___VIC { get; set; }
        public string Reporting_Obligations___WA { get; set; }
        public string Reporting_hours___Paid { get; set; }
        public string Reporting_hours___Unpaid { get; set; }
        public string Reporting_hours___Total { get; set; }

    }
}