# History Of Web Application

This project is the source code related to the seminary "Evoluzione dei pattern di sviluppo di applicazioni web based" (Evolution of development patterns on web applications).

This project is built on:

- Apache + bash script for cgi-bin example
- Apache + PHP + MYSQL for scripting example
- Asp.net core + MYSQL for MVC example
- Asp.ent core + MYSQL + Angular for SPA example

## Tools

### Visual Studio Community Edition
This is used for asp.net core development, is free and fully functional but only for Windows OS. MacOS users can use Visual Studio for Mac or Visual studio code. Linux user can use Visual Studio Code.

### Visula Studio Code
Visual Studio Code is used for angular6 application and PHP

### Docker
Docker is used to running all services in single containers (apache, nginx, mysql,...). This is available only on Windows Professional or Linux.


## Run docker environment
Docker environment is self-contained and can be activated by
```
cd  /where you have root of this project/
docker-compose up

```
Just wait until all containers are built and use the link below to test applications.

CGI and Script example are mapped volumes so changes to the files work directly, in other cases application are built so container have to be re-created using `docker-compose up --build --force-recreate`

### CGI-BIN
- http://localhost:9080/get-the-content (Docker instance)

### Script
- http://localhost:9082/
  
### MVC
- https://localhost:9083/
  
### SPA
- API: https://localhost:9084/swagger/index.html
- FE:  http://localhost:9085


## Running on local environment
You can also run in local machine, following manual steps

### CGI-BIN
Install an Apache server and configure a virtual host. You can use [this](https://github.com/hypoport/httpd-cgi/blob/master/httpd.conf) as reference

### Script
Install an Apache server with php and setup the virtual host, or simply open a terminal from ./script folder and run `php -S localhost:8000`, using the built-in server

### MVC
Open the .sln file using visual studio and click the play button. Running from local appsettings.js configuration is used (in production env keys override this.)


#### From Visual Studio
- https://localhost:44357/
  
### SPA
For the API, just open the .sln file using visual studio and click the play button. Running from local appsettings.js configuration is used (in production env keys ovverride this.) as in MVC example.

To run the frontend:
```
npm install
ng serve
```

You can open these urls (port may vary):

- API https://localhost:44320/swagger/index.html
- FE  http://localhost:4200


## More to read

[Oauth2: GitHub Analytics: Oauth Killer Application](https://www.codeproject.com/Articles/1178156/GitHub-Analytics-Oauth-Killer-Application)
[Api Gateway: Api Gateway in un esempio pratico](https://www.sintraconsulting.it/api-gateway-definizione-caratteristiche-esempio/)
[Slack API:Slack Pusher: Push Slack Messages to Wordpress]()
[NoSQL:NOSQL or NOT NOSQL?](https://www.codeproject.com/Articles/1275260/Slack-Pusher-push-slack-messages-to-Wordpress)
[Headless CMS: Inside Headless CMS](https://towardsdatascience.com/inside-headless-cms-abf4761f3a8?source=friends_link&sk=34bc5f86a33cc6dc3ddf9c9e8ab2ce5e)
[TDD+ MVC:Build an ASP.NET Wiki to Explain TDD](https://www.codeproject.com/Articles/1267361/Build-an-Asp-net-wiki-to-explain-TDD)
[Docker: Simple tutorial to understand docker basics](https://github.com/zeppaman/docker-basics-tutorial)
