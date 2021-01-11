function fetchCities(str)
{
	var req= new XMLHttpRequest();
	req.open("get","http://localhost/AjaxFile/cities.php?state="+str,true);
	req.send();
	req.onreadystatechange=function(){
		if(req.readyState==4 && req.status==200){
			
			document.getElementById("cities").innerHTML=req.responseText;
		}
	};
}
	