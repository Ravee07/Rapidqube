<!Doctype html>
<html>
  <head>
    <link rel="stylesheet" href="form.css"/>
	<script src="AddCities.js"></script>
  </head>
  <body>
    <div id="form-div">
	  <form="#" method="post">
	    <div>
		  <label>Name</label>
		  <input type="text" name="username"/>
		</div>
		<div>
		  <label>Select state</label>
          <select onchange="fetchCities(this.value)">
		     <option>select state</option>
             <option>Maharashtra</option>
			 <option>Delhi</option>
		  </select>
		</div>
		
		<div>
		  <label>Select city</label>
          <select id="cities">
		    <option>First select state</option>
             
		  </select>
		</div>
		<div>
		  <input type="submit" value="submit"/>
		</div>
		
		</form>
	</div>
  </body>
 </html>
			 