using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator.Repositories
{
    /// <summary>
    /// Repository for retrieving Country data.
    /// </summary>
    public class CountryRepository : ICountryRepository
    {
        /// <summary>
        /// Repository to store country data.
        /// </summary>
        private static Dictionary<string, Country> countries;

        /// <summary>
        /// Used to prevent two threads accessing countries simultaneously
        /// while it's being populated.
        /// </summary>
        private Object countryLock = new Object();

        /// <summary>
        /// The address formatters to use for setting addresses.
        /// </summary>
        private IFormatterRepository formatters;

        /// <summary>
        /// Constructor that populates countries if it hasn't already been done.
        /// </summary>
        public CountryRepository(IFormatterRepository formatterRepository)
        {
            this.formatters = formatterRepository;

            if (countries == null || countries.Count == 0)
            {
                PopulateCountries();
            }
        }

        /// <summary>
        /// Gets a Country instance based on its name.
        /// </summary>
        /// <param name="name">The name of the country to fetch.</param>
        /// <returns>A populated Country instance, or null.</returns>
        public Country GetByName(string name)
        {
            return countries[name];
        }

        /// <summary>
        /// Method to populate the countries dictionary.
        /// </summary>
        protected void PopulateCountries()
        {
            lock(countryLock)
            {
                if (countries == null)
                {
                    countries = new Dictionary<string, Country>(StringComparer.OrdinalIgnoreCase);
                }
                countries.Add("Afghanistan", new Country { Name = "Afghanistan", Code = "AF", AddressSingleLineFormat = formatters.Get("Afghanistan") });
                countries.Add("Åland Islands", new Country { Name = "Åland Islands", Code = "AX", AddressSingleLineFormat = formatters.Get("Åland Islands") });
                countries.Add("Albania", new Country { Name = "Albania", Code = "AL", AddressSingleLineFormat = formatters.Get("Albania") });
                countries.Add("Algeria", new Country { Name = "Algeria", Code = "DZ", AddressSingleLineFormat = formatters.Get("Algeria") });
                countries.Add("American Samoa", new Country { Name = "American Samoa", Code = "AS", AddressSingleLineFormat = formatters.Get("American Samoa") });
                countries.Add("Andorra", new Country { Name = "Andorra", Code = "AD", AddressSingleLineFormat = formatters.Get("Andorra") });
                countries.Add("Angola", new Country { Name = "Angola", Code = "AO", AddressSingleLineFormat = formatters.Get("Angola") });
                countries.Add("Anguilla", new Country { Name = "Anguilla", Code = "AI", AddressSingleLineFormat = formatters.Get("Anguilla") });
                countries.Add("Antarctica", new Country { Name = "Antarctica", Code = "AQ", AddressSingleLineFormat = formatters.Get("Antarctica") });
                countries.Add("Antigua and Barbuda", new Country { Name = "Antigua and Barbuda", Code = "AG", AddressSingleLineFormat = formatters.Get("Antigua and Barbuda") });
                countries.Add("Argentina", new Country { Name = "Argentina", Code = "AR", AddressSingleLineFormat = formatters.Get("Argentina") });
                countries.Add("Armenia", new Country { Name = "Armenia", Code = "AM", AddressSingleLineFormat = formatters.Get("Armenia") });
                countries.Add("Aruba", new Country { Name = "Aruba", Code = "AW", AddressSingleLineFormat = formatters.Get("Aruba") });
                countries.Add("Australia", new Country { Name = "Australia", Code = "AU", AddressSingleLineFormat = formatters.Get("Australia") });
                countries.Add("Austria", new Country { Name = "Austria", Code = "AT", AddressSingleLineFormat = formatters.Get("Austria") });
                countries.Add("Azerbaijan", new Country { Name = "Azerbaijan", Code = "AZ", AddressSingleLineFormat = formatters.Get("Azerbaijan") });
                countries.Add("Bahamas", new Country { Name = "Bahamas", Code = "BS", AddressSingleLineFormat = formatters.Get("Bahamas") });
                countries.Add("Bahrain", new Country { Name = "Bahrain", Code = "BH", AddressSingleLineFormat = formatters.Get("Bahrain") });
                countries.Add("Bangladesh", new Country { Name = "Bangladesh", Code = "BD", AddressSingleLineFormat = formatters.Get("Bangladesh") });
                countries.Add("Barbados", new Country { Name = "Barbados", Code = "BB", AddressSingleLineFormat = formatters.Get("Barbados") });
                countries.Add("Belarus", new Country { Name = "Belarus", Code = "BY", AddressSingleLineFormat = formatters.Get("Belarus") });
                countries.Add("Belgium", new Country { Name = "Belgium", Code = "BE", AddressSingleLineFormat = formatters.Get("Belgium") });
                countries.Add("Belize", new Country { Name = "Belize", Code = "BZ", AddressSingleLineFormat = formatters.Get("Belize") });
                countries.Add("Benin", new Country { Name = "Benin", Code = "BJ", AddressSingleLineFormat = formatters.Get("Benin") });
                countries.Add("Bermuda", new Country { Name = "Bermuda", Code = "BM", AddressSingleLineFormat = formatters.Get("Bermuda") });
                countries.Add("Bhutan", new Country { Name = "Bhutan", Code = "BT", AddressSingleLineFormat = formatters.Get("Bhutan") });
                countries.Add("Bolivia, Plurinational State of", new Country { Name = "Bolivia, Plurinational State of", Code = "BO", AddressSingleLineFormat = formatters.Get("Bolivia, Plurinational State of") });
                countries.Add("Bonaire, Sint Eustatius and Saba", new Country { Name = "Bonaire, Sint Eustatius and Saba", Code = "BQ", AddressSingleLineFormat = formatters.Get("Bonaire, Sint Eustatius and Saba") });
                countries.Add("Bosnia and Herzegovina", new Country { Name = "Bosnia and Herzegovina", Code = "BA", AddressSingleLineFormat = formatters.Get("Bosnia and Herzegovina") });
                countries.Add("Botswana", new Country { Name = "Botswana", Code = "BW", AddressSingleLineFormat = formatters.Get("Botswana") });
                countries.Add("Bouvet Island", new Country { Name = "Bouvet Island", Code = "BV", AddressSingleLineFormat = formatters.Get("Bouvet Island") });
                countries.Add("Brazil", new Country { Name = "Brazil", Code = "BR", AddressSingleLineFormat = formatters.Get("Brazil") });
                countries.Add("British Indian Ocean Territory", new Country { Name = "British Indian Ocean Territory", Code = "IO", AddressSingleLineFormat = formatters.Get("British Indian Ocean Territory") });
                countries.Add("Brunei Darussalam", new Country { Name = "Brunei Darussalam", Code = "BN", AddressSingleLineFormat = formatters.Get("Brunei Darussalam") });
                countries.Add("Bulgaria", new Country { Name = "Bulgaria", Code = "BG", AddressSingleLineFormat = formatters.Get("Bulgaria") });
                countries.Add("Burkina Faso", new Country { Name = "Burkina Faso", Code = "BF", AddressSingleLineFormat = formatters.Get("Burkina Faso") });
                countries.Add("Burundi", new Country { Name = "Burundi", Code = "BI", AddressSingleLineFormat = formatters.Get("Burundi") });
                countries.Add("Cambodia", new Country { Name = "Cambodia", Code = "KH", AddressSingleLineFormat = formatters.Get("Cambodia") });
                countries.Add("Cameroon", new Country { Name = "Cameroon", Code = "CM", AddressSingleLineFormat = formatters.Get("Cameroon") });
                countries.Add("Canada", new Country { Name = "Canada", Code = "CA", AddressSingleLineFormat = formatters.Get("Canada") });
                countries.Add("Cape Verde", new Country { Name = "Cape Verde", Code = "CV", AddressSingleLineFormat = formatters.Get("Cape Verde") });
                countries.Add("Cayman Islands", new Country { Name = "Cayman Islands", Code = "KY", AddressSingleLineFormat = formatters.Get("Cayman Islands") });
                countries.Add("Central African Republic", new Country { Name = "Central African Republic", Code = "CF", AddressSingleLineFormat = formatters.Get("Central African Republic") });
                countries.Add("Chad", new Country { Name = "Chad", Code = "TD", AddressSingleLineFormat = formatters.Get("Chad") });
                countries.Add("Chile", new Country { Name = "Chile", Code = "CL", AddressSingleLineFormat = formatters.Get("Chile") });
                countries.Add("China", new Country { Name = "China", Code = "CN", AddressSingleLineFormat = formatters.Get("China") });
                countries.Add("Christmas Island", new Country { Name = "Christmas Island", Code = "CX", AddressSingleLineFormat = formatters.Get("Christmas Island") });
                countries.Add("Cocos (Keeling) Islands", new Country { Name = "Cocos (Keeling) Islands", Code = "CC", AddressSingleLineFormat = formatters.Get("Cocos (Keeling) Islands") });
                countries.Add("Colombia", new Country { Name = "Colombia", Code = "CO", AddressSingleLineFormat = formatters.Get("Colombia") });
                countries.Add("Comoros", new Country { Name = "Comoros", Code = "KM", AddressSingleLineFormat = formatters.Get("Comoros") });
                countries.Add("Congo", new Country { Name = "Congo", Code = "CG", AddressSingleLineFormat = formatters.Get("Congo") });
                countries.Add("Congo, the Democratic Republic of the", new Country { Name = "Congo, the Democratic Republic of the", Code = "CD", AddressSingleLineFormat = formatters.Get("Congo, the Democratic Republic of the") });
                countries.Add("Cook Islands", new Country { Name = "Cook Islands", Code = "CK", AddressSingleLineFormat = formatters.Get("Cook Islands") });
                countries.Add("Costa Rica", new Country { Name = "Costa Rica", Code = "CR", AddressSingleLineFormat = formatters.Get("Costa Rica") });
                countries.Add("Côte d'Ivoire", new Country { Name = "Côte d'Ivoire", Code = "CI", AddressSingleLineFormat = formatters.Get("Côte d'Ivoire") });
                countries.Add("Croatia", new Country { Name = "Croatia", Code = "HR", AddressSingleLineFormat = formatters.Get("Croatia") });
                countries.Add("Cuba", new Country { Name = "Cuba", Code = "CU", AddressSingleLineFormat = formatters.Get("Cuba") });
                countries.Add("Curaçao", new Country { Name = "Curaçao", Code = "CW", AddressSingleLineFormat = formatters.Get("Curaçao") });
                countries.Add("Cyprus", new Country { Name = "Cyprus", Code = "CY", AddressSingleLineFormat = formatters.Get("Cyprus") });
                countries.Add("Czech Republic", new Country { Name = "Czech Republic", Code = "CZ", AddressSingleLineFormat = formatters.Get("Czech Republic") });
                countries.Add("Denmark", new Country { Name = "Denmark", Code = "DK", AddressSingleLineFormat = formatters.Get("Denmark") });
                countries.Add("Djibouti", new Country { Name = "Djibouti", Code = "DJ", AddressSingleLineFormat = formatters.Get("Djibouti") });
                countries.Add("Dominica", new Country { Name = "Dominica", Code = "DM", AddressSingleLineFormat = formatters.Get("Dominica") });
                countries.Add("Dominican Republic", new Country { Name = "Dominican Republic", Code = "DO", AddressSingleLineFormat = formatters.Get("Dominican Republic") });
                countries.Add("Ecuador", new Country { Name = "Ecuador", Code = "EC", AddressSingleLineFormat = formatters.Get("Ecuador") });
                countries.Add("Egypt", new Country { Name = "Egypt", Code = "EG", AddressSingleLineFormat = formatters.Get("Egypt") });
                countries.Add("El Salvador", new Country { Name = "El Salvador", Code = "SV", AddressSingleLineFormat = formatters.Get("El Salvador") });
                countries.Add("Equatorial Guinea", new Country { Name = "Equatorial Guinea", Code = "GQ", AddressSingleLineFormat = formatters.Get("Equatorial Guinea") });
                countries.Add("Eritrea", new Country { Name = "Eritrea", Code = "ER", AddressSingleLineFormat = formatters.Get("Eritrea") });
                countries.Add("Estonia", new Country { Name = "Estonia", Code = "EE", AddressSingleLineFormat = formatters.Get("Estonia") });
                countries.Add("Ethiopia", new Country { Name = "Ethiopia", Code = "ET", AddressSingleLineFormat = formatters.Get("Ethiopia") });
                countries.Add("Falkland Islands (Malvinas)", new Country { Name = "Falkland Islands (Malvinas)", Code = "FK", AddressSingleLineFormat = formatters.Get("Falkland Islands (Malvinas)") });
                countries.Add("Faroe Islands", new Country { Name = "Faroe Islands", Code = "FO", AddressSingleLineFormat = formatters.Get("Faroe Islands") });
                countries.Add("Fiji", new Country { Name = "Fiji", Code = "FJ", AddressSingleLineFormat = formatters.Get("Fiji") });
                countries.Add("Finland", new Country { Name = "Finland", Code = "FI", AddressSingleLineFormat = formatters.Get("Finland") });
                countries.Add("France", new Country { Name = "France", Code = "FR", AddressSingleLineFormat = formatters.Get("France") });
                countries.Add("French Guiana", new Country { Name = "French Guiana", Code = "GF", AddressSingleLineFormat = formatters.Get("French Guiana") });
                countries.Add("French Polynesia", new Country { Name = "French Polynesia", Code = "PF", AddressSingleLineFormat = formatters.Get("French Polynesia") });
                countries.Add("French Southern Territories", new Country { Name = "French Southern Territories", Code = "TF", AddressSingleLineFormat = formatters.Get("French Southern Territories") });
                countries.Add("Gabon", new Country { Name = "Gabon", Code = "GA", AddressSingleLineFormat = formatters.Get("Gabon") });
                countries.Add("Gambia", new Country { Name = "Gambia", Code = "GM", AddressSingleLineFormat = formatters.Get("Gambia") });
                countries.Add("Georgia", new Country { Name = "Georgia", Code = "GE", AddressSingleLineFormat = formatters.Get("Georgia") });
                countries.Add("Germany", new Country { Name = "Germany", Code = "DE", AddressSingleLineFormat = formatters.Get("Germany") });
                countries.Add("Ghana", new Country { Name = "Ghana", Code = "GH", AddressSingleLineFormat = formatters.Get("Ghana") });
                countries.Add("Gibraltar", new Country { Name = "Gibraltar", Code = "GI", AddressSingleLineFormat = formatters.Get("Gibraltar") });
                countries.Add("Greece", new Country { Name = "Greece", Code = "GR", AddressSingleLineFormat = formatters.Get("Greece") });
                countries.Add("Greenland", new Country { Name = "Greenland", Code = "GL", AddressSingleLineFormat = formatters.Get("Greenland") });
                countries.Add("Grenada", new Country { Name = "Grenada", Code = "GD", AddressSingleLineFormat = formatters.Get("Grenada") });
                countries.Add("Guadeloupe", new Country { Name = "Guadeloupe", Code = "GP", AddressSingleLineFormat = formatters.Get("Guadeloupe") });
                countries.Add("Guam", new Country { Name = "Guam", Code = "GU", AddressSingleLineFormat = formatters.Get("Guam") });
                countries.Add("Guatemala", new Country { Name = "Guatemala", Code = "GT", AddressSingleLineFormat = formatters.Get("Guatemala") });
                countries.Add("Guernsey", new Country { Name = "Guernsey", Code = "GG", AddressSingleLineFormat = formatters.Get("Guernsey") });
                countries.Add("Guinea", new Country { Name = "Guinea", Code = "GN", AddressSingleLineFormat = formatters.Get("Guinea") });
                countries.Add("Guinea-Bissau", new Country { Name = "Guinea-Bissau", Code = "GW", AddressSingleLineFormat = formatters.Get("Guinea-Bissau") });
                countries.Add("Guyana", new Country { Name = "Guyana", Code = "GY", AddressSingleLineFormat = formatters.Get("Guyana") });
                countries.Add("Haiti", new Country { Name = "Haiti", Code = "HT", AddressSingleLineFormat = formatters.Get("Haiti") });
                countries.Add("Heard Island and McDonald Islands", new Country { Name = "Heard Island and McDonald Islands", Code = "HM", AddressSingleLineFormat = formatters.Get("Heard Island and McDonald Islands") });
                countries.Add("Holy See (Vatican City State)", new Country { Name = "Holy See (Vatican City State)", Code = "VA", AddressSingleLineFormat = formatters.Get("Holy See (Vatican City State)") });
                countries.Add("Honduras", new Country { Name = "Honduras", Code = "HN", AddressSingleLineFormat = formatters.Get("Honduras") });
                countries.Add("Hong Kong", new Country { Name = "Hong Kong", Code = "HK", AddressSingleLineFormat = formatters.Get("Hong Kong") });
                countries.Add("Hungary", new Country { Name = "Hungary", Code = "HU", AddressSingleLineFormat = formatters.Get("Hungary") });
                countries.Add("Iceland", new Country { Name = "Iceland", Code = "IS", AddressSingleLineFormat = formatters.Get("Iceland") });
                countries.Add("India", new Country { Name = "India", Code = "IN", AddressSingleLineFormat = formatters.Get("India") });
                countries.Add("Indonesia", new Country { Name = "Indonesia", Code = "ID", AddressSingleLineFormat = formatters.Get("Indonesia") });
                countries.Add("Iran, Islamic Republic of", new Country { Name = "Iran, Islamic Republic of", Code = "IR", AddressSingleLineFormat = formatters.Get("Iran, Islamic Republic of") });
                countries.Add("Iraq", new Country { Name = "Iraq", Code = "IQ", AddressSingleLineFormat = formatters.Get("Iraq") });
                countries.Add("Ireland", new Country { Name = "Ireland", Code = "IE", AddressSingleLineFormat = formatters.Get("Ireland") });
                countries.Add("Isle of Man", new Country { Name = "Isle of Man", Code = "IM", AddressSingleLineFormat = formatters.Get("Isle of Man") });
                countries.Add("Israel", new Country { Name = "Israel", Code = "IL", AddressSingleLineFormat = formatters.Get("Israel") });
                countries.Add("Italy", new Country { Name = "Italy", Code = "IT", AddressSingleLineFormat = formatters.Get("Italy") });
                countries.Add("Jamaica", new Country { Name = "Jamaica", Code = "JM", AddressSingleLineFormat = formatters.Get("Jamaica") });
                countries.Add("Japan", new Country { Name = "Japan", Code = "JP", AddressSingleLineFormat = formatters.Get("Japan") });
                countries.Add("Jersey", new Country { Name = "Jersey", Code = "JE", AddressSingleLineFormat = formatters.Get("Jersey") });
                countries.Add("Jordan", new Country { Name = "Jordan", Code = "JO", AddressSingleLineFormat = formatters.Get("Jordan") });
                countries.Add("Kazakhstan", new Country { Name = "Kazakhstan", Code = "KZ", AddressSingleLineFormat = formatters.Get("Kazakhstan") });
                countries.Add("Kenya", new Country { Name = "Kenya", Code = "KE", AddressSingleLineFormat = formatters.Get("Kenya") });
                countries.Add("Kiribati", new Country { Name = "Kiribati", Code = "KI", AddressSingleLineFormat = formatters.Get("Kiribati") });
                countries.Add("Korea, Democratic People's Republic of", new Country { Name = "Korea, Democratic People's Republic of", Code = "KP", AddressSingleLineFormat = formatters.Get("Korea, Democratic People's Republic of") });
                countries.Add("Korea, Republic of", new Country { Name = "Korea, Republic of", Code = "KR", AddressSingleLineFormat = formatters.Get("Korea, Republic of") });
                countries.Add("Kuwait", new Country { Name = "Kuwait", Code = "KW", AddressSingleLineFormat = formatters.Get("Kuwait") });
                countries.Add("Kyrgyzstan", new Country { Name = "Kyrgyzstan", Code = "KG", AddressSingleLineFormat = formatters.Get("Kyrgyzstan") });
                countries.Add("Lao People's Democratic Republic", new Country { Name = "Lao People's Democratic Republic", Code = "LA", AddressSingleLineFormat = formatters.Get("Lao People's Democratic Republic") });
                countries.Add("Latvia", new Country { Name = "Latvia", Code = "LV", AddressSingleLineFormat = formatters.Get("Latvia") });
                countries.Add("Lebanon", new Country { Name = "Lebanon", Code = "LB", AddressSingleLineFormat = formatters.Get("Lebanon") });
                countries.Add("Lesotho", new Country { Name = "Lesotho", Code = "LS", AddressSingleLineFormat = formatters.Get("Lesotho") });
                countries.Add("Liberia", new Country { Name = "Liberia", Code = "LR", AddressSingleLineFormat = formatters.Get("Liberia") });
                countries.Add("Libya", new Country { Name = "Libya", Code = "LY", AddressSingleLineFormat = formatters.Get("Libya") });
                countries.Add("Liechtenstein", new Country { Name = "Liechtenstein", Code = "LI", AddressSingleLineFormat = formatters.Get("Liechtenstein") });
                countries.Add("Lithuania", new Country { Name = "Lithuania", Code = "LT", AddressSingleLineFormat = formatters.Get("Lithuania") });
                countries.Add("Luxembourg", new Country { Name = "Luxembourg", Code = "LU", AddressSingleLineFormat = formatters.Get("Luxembourg") });
                countries.Add("Macao", new Country { Name = "Macao", Code = "MO", AddressSingleLineFormat = formatters.Get("Macao") });
                countries.Add("Macedonia, the Former Yugoslav Republic of", new Country { Name = "Macedonia, the Former Yugoslav Republic of", Code = "MK", AddressSingleLineFormat = formatters.Get("Macedonia, the Former Yugoslav Republic of") });
                countries.Add("Madagascar", new Country { Name = "Madagascar", Code = "MG", AddressSingleLineFormat = formatters.Get("Madagascar") });
                countries.Add("Malawi", new Country { Name = "Malawi", Code = "MW", AddressSingleLineFormat = formatters.Get("Malawi") });
                countries.Add("Malaysia", new Country { Name = "Malaysia", Code = "MY", AddressSingleLineFormat = formatters.Get("Malaysia") });
                countries.Add("Maldives", new Country { Name = "Maldives", Code = "MV", AddressSingleLineFormat = formatters.Get("Maldives") });
                countries.Add("Mali", new Country { Name = "Mali", Code = "ML", AddressSingleLineFormat = formatters.Get("Mali") });
                countries.Add("Malta", new Country { Name = "Malta", Code = "MT", AddressSingleLineFormat = formatters.Get("Malta") });
                countries.Add("Marshall Islands", new Country { Name = "Marshall Islands", Code = "MH", AddressSingleLineFormat = formatters.Get("Marshall Islands") });
                countries.Add("Martinique", new Country { Name = "Martinique", Code = "MQ", AddressSingleLineFormat = formatters.Get("Martinique") });
                countries.Add("Mauritania", new Country { Name = "Mauritania", Code = "MR", AddressSingleLineFormat = formatters.Get("Mauritania") });
                countries.Add("Mauritius", new Country { Name = "Mauritius", Code = "MU", AddressSingleLineFormat = formatters.Get("Mauritius") });
                countries.Add("Mayotte", new Country { Name = "Mayotte", Code = "YT", AddressSingleLineFormat = formatters.Get("Mayotte") });
                countries.Add("Mexico", new Country { Name = "Mexico", Code = "MX", AddressSingleLineFormat = formatters.Get("Mexico") });
                countries.Add("Micronesia, Federated States of", new Country { Name = "Micronesia, Federated States of", Code = "FM", AddressSingleLineFormat = formatters.Get("Micronesia, Federated States of") });
                countries.Add("Moldova, Republic of", new Country { Name = "Moldova, Republic of", Code = "MD", AddressSingleLineFormat = formatters.Get("Moldova, Republic of") });
                countries.Add("Monaco", new Country { Name = "Monaco", Code = "MC", AddressSingleLineFormat = formatters.Get("Monaco") });
                countries.Add("Mongolia", new Country { Name = "Mongolia", Code = "MN", AddressSingleLineFormat = formatters.Get("Mongolia") });
                countries.Add("Montenegro", new Country { Name = "Montenegro", Code = "ME", AddressSingleLineFormat = formatters.Get("Montenegro") });
                countries.Add("Montserrat", new Country { Name = "Montserrat", Code = "MS", AddressSingleLineFormat = formatters.Get("Montserrat") });
                countries.Add("Morocco", new Country { Name = "Morocco", Code = "MA", AddressSingleLineFormat = formatters.Get("Morocco") });
                countries.Add("Mozambique", new Country { Name = "Mozambique", Code = "MZ", AddressSingleLineFormat = formatters.Get("Mozambique") });
                countries.Add("Myanmar", new Country { Name = "Myanmar", Code = "MM", AddressSingleLineFormat = formatters.Get("Myanmar") });
                countries.Add("Namibia", new Country { Name = "Namibia", Code = "NA", AddressSingleLineFormat = formatters.Get("Namibia") });
                countries.Add("Nauru", new Country { Name = "Nauru", Code = "NR", AddressSingleLineFormat = formatters.Get("Nauru") });
                countries.Add("Nepal", new Country { Name = "Nepal", Code = "NP", AddressSingleLineFormat = formatters.Get("Nepal") });
                countries.Add("Netherlands", new Country { Name = "Netherlands", Code = "NL", AddressSingleLineFormat = formatters.Get("Netherlands") });
                countries.Add("New Caledonia", new Country { Name = "New Caledonia", Code = "NC", AddressSingleLineFormat = formatters.Get("New Caledonia") });
                countries.Add("New Zealand", new Country { Name = "New Zealand", Code = "NZ", AddressSingleLineFormat = formatters.Get("New Zealand") });
                countries.Add("Nicaragua", new Country { Name = "Nicaragua", Code = "NI", AddressSingleLineFormat = formatters.Get("Nicaragua") });
                countries.Add("Niger", new Country { Name = "Niger", Code = "NE", AddressSingleLineFormat = formatters.Get("Niger") });
                countries.Add("Nigeria", new Country { Name = "Nigeria", Code = "NG", AddressSingleLineFormat = formatters.Get("Nigeria") });
                countries.Add("Niue", new Country { Name = "Niue", Code = "NU", AddressSingleLineFormat = formatters.Get("Niue") });
                countries.Add("Norfolk Island", new Country { Name = "Norfolk Island", Code = "NF", AddressSingleLineFormat = formatters.Get("Norfolk Island") });
                countries.Add("Northern Mariana Islands", new Country { Name = "Northern Mariana Islands", Code = "MP", AddressSingleLineFormat = formatters.Get("Northern Mariana Islands") });
                countries.Add("Norway", new Country { Name = "Norway", Code = "NO", AddressSingleLineFormat = formatters.Get("Norway") });
                countries.Add("Oman", new Country { Name = "Oman", Code = "OM", AddressSingleLineFormat = formatters.Get("Oman") });
                countries.Add("Pakistan", new Country { Name = "Pakistan", Code = "PK", AddressSingleLineFormat = formatters.Get("Pakistan") });
                countries.Add("Palau", new Country { Name = "Palau", Code = "PW", AddressSingleLineFormat = formatters.Get("Palau") });
                countries.Add("Palestine, State of", new Country { Name = "Palestine, State of", Code = "PS", AddressSingleLineFormat = formatters.Get("Palestine, State of") });
                countries.Add("Panama", new Country { Name = "Panama", Code = "PA", AddressSingleLineFormat = formatters.Get("Panama") });
                countries.Add("Papua New Guinea", new Country { Name = "Papua New Guinea", Code = "PG", AddressSingleLineFormat = formatters.Get("Papua New Guinea") });
                countries.Add("Paraguay", new Country { Name = "Paraguay", Code = "PY", AddressSingleLineFormat = formatters.Get("Paraguay") });
                countries.Add("Peru", new Country { Name = "Peru", Code = "PE", AddressSingleLineFormat = formatters.Get("Peru") });
                countries.Add("Philippines", new Country { Name = "Philippines", Code = "PH", AddressSingleLineFormat = formatters.Get("Philippines") });
                countries.Add("Pitcairn", new Country { Name = "Pitcairn", Code = "PN", AddressSingleLineFormat = formatters.Get("Pitcairn") });
                countries.Add("Poland", new Country { Name = "Poland", Code = "PL", AddressSingleLineFormat = formatters.Get("Poland") });
                countries.Add("Portugal", new Country { Name = "Portugal", Code = "PT", AddressSingleLineFormat = formatters.Get("Portugal") });
                countries.Add("Puerto Rico", new Country { Name = "Puerto Rico", Code = "PR", AddressSingleLineFormat = formatters.Get("Puerto Rico") });
                countries.Add("Qatar", new Country { Name = "Qatar", Code = "QA", AddressSingleLineFormat = formatters.Get("Qatar") });
                countries.Add("Réunion", new Country { Name = "Réunion", Code = "RE", AddressSingleLineFormat = formatters.Get("Réunion") });
                countries.Add("Romania", new Country { Name = "Romania", Code = "RO", AddressSingleLineFormat = formatters.Get("Romania") });
                countries.Add("Russian Federation", new Country { Name = "Russian Federation", Code = "RU", AddressSingleLineFormat = formatters.Get("Russian Federation") });
                countries.Add("Rwanda", new Country { Name = "Rwanda", Code = "RW", AddressSingleLineFormat = formatters.Get("Rwanda") });
                countries.Add("Saint Barthlemy", new Country { Name = "Saint Barthlemy", Code = "BL", AddressSingleLineFormat = formatters.Get("Saint Barthlemy") });
                countries.Add("Saint Helena, Ascension and Tristan da Cunha", new Country { Name = "Saint Helena, Ascension and Tristan da Cunha", Code = "SH", AddressSingleLineFormat = formatters.Get("Saint Helena, Ascension and Tristan da Cunha") });
                countries.Add("Saint Kitts and Nevis", new Country { Name = "Saint Kitts and Nevis", Code = "KN", AddressSingleLineFormat = formatters.Get("Saint Kitts and Nevis") });
                countries.Add("Saint Lucia", new Country { Name = "Saint Lucia", Code = "LC", AddressSingleLineFormat = formatters.Get("Saint Lucia") });
                countries.Add("Saint Martin (French part)", new Country { Name = "Saint Martin (French part)", Code = "MF", AddressSingleLineFormat = formatters.Get("Saint Martin (French part)") });
                countries.Add("Saint Pierre and Miquelon", new Country { Name = "Saint Pierre and Miquelon", Code = "PM", AddressSingleLineFormat = formatters.Get("Saint Pierre and Miquelon") });
                countries.Add("Saint Vincent and the Grenadines", new Country { Name = "Saint Vincent and the Grenadines", Code = "VC", AddressSingleLineFormat = formatters.Get("Saint Vincent and the Grenadines") });
                countries.Add("Samoa", new Country { Name = "Samoa", Code = "WS", AddressSingleLineFormat = formatters.Get("Samoa") });
                countries.Add("San Marino", new Country { Name = "San Marino", Code = "SM", AddressSingleLineFormat = formatters.Get("San Marino") });
                countries.Add("Sao Tome and Principe", new Country { Name = "Sao Tome and Principe", Code = "ST", AddressSingleLineFormat = formatters.Get("Sao Tome and Principe") });
                countries.Add("Saudi Arabia", new Country { Name = "Saudi Arabia", Code = "SA", AddressSingleLineFormat = formatters.Get("Saudi Arabia") });
                countries.Add("Senegal", new Country { Name = "Senegal", Code = "SN", AddressSingleLineFormat = formatters.Get("Senegal") });
                countries.Add("Serbia", new Country { Name = "Serbia", Code = "RS", AddressSingleLineFormat = formatters.Get("Serbia") });
                countries.Add("Seychelles", new Country { Name = "Seychelles", Code = "SC", AddressSingleLineFormat = formatters.Get("Seychelles") });
                countries.Add("Sierra Leone", new Country { Name = "Sierra Leone", Code = "SL", AddressSingleLineFormat = formatters.Get("Sierra Leone") });
                countries.Add("Singapore", new Country { Name = "Singapore", Code = "SG", AddressSingleLineFormat = formatters.Get("Singapore") });
                countries.Add("Sint Maarten (Dutch part)", new Country { Name = "Sint Maarten (Dutch part)", Code = "SX", AddressSingleLineFormat = formatters.Get("Sint Maarten (Dutch part)") });
                countries.Add("Slovakia", new Country { Name = "Slovakia", Code = "SK", AddressSingleLineFormat = formatters.Get("Slovakia") });
                countries.Add("Slovenia", new Country { Name = "Slovenia", Code = "SI", AddressSingleLineFormat = formatters.Get("Slovenia") });
                countries.Add("Solomon Islands", new Country { Name = "Solomon Islands", Code = "SB", AddressSingleLineFormat = formatters.Get("Solomon Islands") });
                countries.Add("Somalia", new Country { Name = "Somalia", Code = "SO", AddressSingleLineFormat = formatters.Get("Somalia") });
                countries.Add("South Africa", new Country { Name = "South Africa", Code = "ZA", AddressSingleLineFormat = formatters.Get("South Africa") });
                countries.Add("South Georgia and the South Sandwich Islands", new Country { Name = "South Georgia and the South Sandwich Islands", Code = "GS", AddressSingleLineFormat = formatters.Get("South Georgia and the South Sandwich Islands") });
                countries.Add("South Sudan", new Country { Name = "South Sudan", Code = "SS", AddressSingleLineFormat = formatters.Get("South Sudan") });
                countries.Add("Spain", new Country { Name = "Spain", Code = "ES", AddressSingleLineFormat = formatters.Get("Spain") });
                countries.Add("Sri Lanka", new Country { Name = "Sri Lanka", Code = "LK", AddressSingleLineFormat = formatters.Get("Sri Lanka") });
                countries.Add("Sudan", new Country { Name = "Sudan", Code = "SD", AddressSingleLineFormat = formatters.Get("Sudan") });
                countries.Add("Suriname", new Country { Name = "Suriname", Code = "SR", AddressSingleLineFormat = formatters.Get("Suriname") });
                countries.Add("Svalbard and Jan Mayen", new Country { Name = "Svalbard and Jan Mayen", Code = "SJ", AddressSingleLineFormat = formatters.Get("Svalbard and Jan Mayen") });
                countries.Add("Swaziland", new Country { Name = "Swaziland", Code = "SZ", AddressSingleLineFormat = formatters.Get("Swaziland") });
                countries.Add("Sweden", new Country { Name = "Sweden", Code = "SE", AddressSingleLineFormat = formatters.Get("Sweden") });
                countries.Add("Switzerland", new Country { Name = "Switzerland", Code = "CH", AddressSingleLineFormat = formatters.Get("Switzerland") });
                countries.Add("Syrian Arab Republic", new Country { Name = "Syrian Arab Republic", Code = "SY", AddressSingleLineFormat = formatters.Get("Syrian Arab Republic") });
                countries.Add("Taiwan, Province of China", new Country { Name = "Taiwan, Province of China", Code = "TW", AddressSingleLineFormat = formatters.Get("Taiwan, Province of China") });
                countries.Add("Tajikistan", new Country { Name = "Tajikistan", Code = "TJ", AddressSingleLineFormat = formatters.Get("Tajikistan") });
                countries.Add("Tanzania, United Republic of", new Country { Name = "Tanzania, United Republic of", Code = "TZ", AddressSingleLineFormat = formatters.Get("Tanzania, United Republic of") });
                countries.Add("Thailand", new Country { Name = "Thailand", Code = "TH", AddressSingleLineFormat = formatters.Get("Thailand") });
                countries.Add("Timor-Leste", new Country { Name = "Timor-Leste", Code = "TL", AddressSingleLineFormat = formatters.Get("Timor-Leste") });
                countries.Add("Togo", new Country { Name = "Togo", Code = "TG", AddressSingleLineFormat = formatters.Get("Togo") });
                countries.Add("Tokelau", new Country { Name = "Tokelau", Code = "TK", AddressSingleLineFormat = formatters.Get("Tokelau") });
                countries.Add("Tonga", new Country { Name = "Tonga", Code = "TO", AddressSingleLineFormat = formatters.Get("Tonga") });
                countries.Add("Trinidad and Tobago", new Country { Name = "Trinidad and Tobago", Code = "TT", AddressSingleLineFormat = formatters.Get("Trinidad and Tobago") });
                countries.Add("Tunisia", new Country { Name = "Tunisia", Code = "TN", AddressSingleLineFormat = formatters.Get("Tunisia") });
                countries.Add("Turkey", new Country { Name = "Turkey", Code = "TR", AddressSingleLineFormat = formatters.Get("Turkey") });
                countries.Add("Turkmenistan", new Country { Name = "Turkmenistan", Code = "TM", AddressSingleLineFormat = formatters.Get("Turkmenistan") });
                countries.Add("Turks and Caicos Islands", new Country { Name = "Turks and Caicos Islands", Code = "TC", AddressSingleLineFormat = formatters.Get("Turks and Caicos Islands") });
                countries.Add("Tuvalu", new Country { Name = "Tuvalu", Code = "TV", AddressSingleLineFormat = formatters.Get("Tuvalu") });
                countries.Add("Uganda", new Country { Name = "Uganda", Code = "UG", AddressSingleLineFormat = formatters.Get("Uganda") });
                countries.Add("Ukraine", new Country { Name = "Ukraine", Code = "UA", AddressSingleLineFormat = formatters.Get("Ukraine") });
                countries.Add("United Arab Emirates", new Country { Name = "United Arab Emirates", Code = "AE", AddressSingleLineFormat = formatters.Get("United Arab Emirates") });
                countries.Add("United Kingdom", new Country { Name = "United Kingdom", Code = "GB", AddressSingleLineFormat = formatters.Get("United Kingdom") });
                countries.Add("United States", new Country { Name = "United States", Code = "US", AddressSingleLineFormat = formatters.Get("United States") });
                countries.Add("United States Minor Outlying Islands", new Country { Name = "United States Minor Outlying Islands", Code = "UM", AddressSingleLineFormat = formatters.Get("United States Minor Outlying Islands") });
                countries.Add("Uruguay", new Country { Name = "Uruguay", Code = "UY", AddressSingleLineFormat = formatters.Get("Uruguay") });
                countries.Add("Uzbekistan", new Country { Name = "Uzbekistan", Code = "UZ", AddressSingleLineFormat = formatters.Get("Uzbekistan") });
                countries.Add("Vanuatu", new Country { Name = "Vanuatu", Code = "VU", AddressSingleLineFormat = formatters.Get("Vanuatu") });
                countries.Add("Venezuela, Bolivarian Republic of", new Country { Name = "Venezuela, Bolivarian Republic of", Code = "VE", AddressSingleLineFormat = formatters.Get("Venezuela, Bolivarian Republic of") });
                countries.Add("Viet Nam", new Country { Name = "Viet Nam", Code = "VN", AddressSingleLineFormat = formatters.Get("Viet Nam") });
                countries.Add("Virgin Islands, British", new Country { Name = "Virgin Islands, British", Code = "VG", AddressSingleLineFormat = formatters.Get("Virgin Islands, British") });
                countries.Add("Virgin Islands, U.S.", new Country { Name = "Virgin Islands, U.S.", Code = "VI", AddressSingleLineFormat = formatters.Get("Virgin Islands, U.S.") });
                countries.Add("Wallis and Futuna", new Country { Name = "Wallis and Futuna", Code = "WF", AddressSingleLineFormat = formatters.Get("Wallis and Futuna") });
                countries.Add("Western Sahara", new Country { Name = "Western Sahara", Code = "EH", AddressSingleLineFormat = formatters.Get("Western Sahara") });
                countries.Add("Yemen", new Country { Name = "Yemen", Code = "YE", AddressSingleLineFormat = formatters.Get("Yemen") });
                countries.Add("Zambia", new Country { Name = "Zambia", Code = "ZM", AddressSingleLineFormat = formatters.Get("Zambia") });
                countries.Add("Zimbabwe", new Country { Name = "Zimbabwe", Code = "ZW", AddressSingleLineFormat = formatters.Get("Zimbabwe") });
            }
        }
    }
}
