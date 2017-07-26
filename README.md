# Address Locator
Converts an address into latitude and longitude co-ordinates.

The class library **AddressLocator** does all the heavy lifting, but a sample
console app is included to demonstrate finding an address using OpenStreetMap.
AddressLocator is implemented in .NetStandard 1.4, so it should be compatible
with the following platforms:

* .NET Core 1.0
* .NET Framework 4.6.1
* Mono 4.6
* Xamarin.iOS 10.0
* Xamarin.Android 7.0
* Universal Windows Platform 10

## Background
A while ago, my wife was looking for some part-time work locally. I wrote
some screen-scraping scripts in Python to grab a list of company details from
various directory sites. The results, while plentiful, were of limited use
because we were only interested in local companies.

This prompted me to find the lat/lon co-ordinates of each address in the list. I
hacked together another Python script that queried OpenStreetMap's API. Once the
locations were known, another script was able to calculate the distance of each
company from our home. From there, it was a simple matter to filter the list to
only show companies within, say, 5 kilometres.

## C# Version
The original Python scripts did the job, but were a bit of a hack. I came across
them again recently, and decided to rewrite them as a C# class library.