using System;

class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string statePrivince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = statePrivince;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.Trim().ToLower() == "usa";
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}