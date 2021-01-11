<?php
$state=$_GET['state'];
$c1=array('Mumbai','pune');
$c2=array('New delhi');

if($state=="Maharashtra"){
	foreach($c1 as $c)
	  echo "<option>$c</options>";
}
else if($state=="Delhi"){
	foreach($c2 as $c)
	echo "<option>$c</options>";
}
else{
	echo "<option> First enter state</option>";
}
	
