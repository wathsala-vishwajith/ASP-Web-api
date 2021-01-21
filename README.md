### ASP-Web-api


### Setting up the project


  Download DotNet Core 3.1


### Install Postgres SQL

	I have used the Postgres docker. You could install it using traditional method as well.

### Using Docker

	
	1. cd to the config folder and relocate the docker-compose.yml file any location u prefer.
	2. navigate to the new directory location and run `docker-compose up`
	3. execute the command `docker run <image-name>`.

	
### Setting up the database



1. Navigate to the root folder of the api and run the command
	
	 `dotnet user-secrets set "ConnectionString:supermarketDB" "<connection string>"`

    The format of the connection string is 

      `"Server=localhost;port=6000;database=supermarketDB;User ID=postgres;password=;"`
  
2. To create the migrations, run the command `Add-Migration Persistence.Contexts.AppDbContext`

3. Finally run the command ` update-database `
	
Note: You can use postgress in the cli by running the command 

	    docker exec -it <container-name> psql -U postgres -p


To run the api 

  Navigate to project directory and run the command `dotnet run`

  The api is availabe at ` https://localhost:5001 `
