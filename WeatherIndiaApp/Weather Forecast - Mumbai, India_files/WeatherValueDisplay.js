function lookupWindStringFormat(windnum)
{
	var windstr = lookupWindString(windnum);
	return "<nobr><b>"+windstr+"</b></nobr>";
}

function lookupWindString(windnum)
{
 var windstr="-";

 if (windnum > 360)
	windnum = windnum%360;

 if (windnum >= 0      && windnum < 11.25 ) windstr="North";  
 if (windnum >= 11.25  && windnum < 33.75 ) windstr="NNE";  
 if (windnum >= 33.75  && windnum < 56.25 ) windstr="NE";  
 if (windnum >= 56.25  && windnum < 78.75 ) windstr="ENE";  
 if (windnum >= 78.75  && windnum < 101.25) windstr="East";
 if (windnum >= 101.25 && windnum < 123.75) windstr="ESE";  
 if (windnum >= 123.75 && windnum < 146.25) windstr="SE";  
 if (windnum >= 146.25 && windnum < 168.75) windstr="SSE";  
 if (windnum >= 168.75 && windnum < 191.25) windstr="South";  
 if (windnum >= 191.25 && windnum < 213.75) windstr="SSW";  
 if (windnum >= 213.75 && windnum < 236.25) windstr="SW";  
 if (windnum >= 236.25 && windnum < 258.75) windstr="WSW";  
 if (windnum >= 258.75 && windnum < 281.25) windstr="West";  
 if (windnum >= 281.25 && windnum < 303.75) windstr="WNW";  
 if (windnum >= 303.75 && windnum < 326.25) windstr="NW";  
 if (windnum >= 326.25 && windnum < 348.75) windstr="NNW";  
 if (windnum >= 348.75) windstr="North";  
  

  return windstr;
}


function convertTempIntoUnits(units,temperature,englishunit,metricunit)
{
    if (temperature=='-999') return '-';
    if (temperature=='-9999') return '-';

	var metricval = parseInt((temperature -32)/1.8);
	var englishval = temperature;

	return GetDisplayString(units,englishval,metricval,englishunit,metricunit);
}


function convertWindIntoUnits(units,windspdmph,englishunit,metricunit)
{
	var mps = windspdmph/2.237;
	var metricval = parseInt(mps*3.6);
	var englishval = windspdmph;

	return GetDisplayString(units,englishval,metricval,englishunit,metricunit);
}

function  convertPressureIntoUnits(units,pressurein,englishunit,metricunit)
{
	var englishval = new Number(pressurein);
	var metricval =new Number((pressurein * 33.86));

	return GetDisplayString(units,englishval.toFixed(2),metricval.toFixed(1),englishunit,metricunit);
}

function convertRainIntoUnits(units,rainin,englishunit,metricunit)
{
	if (units=='metric')
		return parseInt(rainin*2.54*10)/10.0;		
	else 
		return rainin;
}

function convertRealTime(value)
{
	if (value!=0)
		return "realtime";
	else
		return "normal";
}

function convertTime(this_conds)
{
	var ageh= this_conds['ageh'];
	var agem= this_conds['agem'];
	var ages= this_conds['ages'];
	var value = (ageh*60+agem*1.0)*60+ages*1.0;

	newHTML = "";
	if (ageh>0)
	{
		newHTML = ageh+" hr "+agem+" min "+ages+" sec ago";
	}
	else if (agem>0)
	{
		newHTML = agem+" min "+ages+" sec ago";
	}
	else
	{
		newHTML = ages+" sec ago";
	}

	return newHTML;
}

function convertHumidity(value)
{
	newHTML = "<b>"+value+"%</b>";
    return newHTML;
}



function GetDisplayString(units,englishval,metricval,englishunit,metricunit)
{
	if (englishval <= -999)
	{
		return "-";
	}	
    else if (units=='both')
    {
        return "<nobr><b>"+englishval+"</b> "+englishunit+"</nobr> / <nobr><b>"+metricval+"</b> "+metricunit+"</nobr>";
    }
    else if (units=='english')
    {
		return "<nobr><b>"+englishval+"</b> "+englishunit+"</nobr>";
    }
    else if (units=='metric')
    {
        return "<nobr><b>"+metricval+"</b> "+metricunit+"</nobr>";
    }
}
