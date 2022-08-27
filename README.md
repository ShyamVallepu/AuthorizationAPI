## Authorization Service
This service is responsible to provide login access to the application and provide security to it with the help of stateless authentication using JWT Tokens.

 1.Open your Visual Studio  and run the service.
 2. Open your browser and head to this URL - https://localhost:44365/swagger/index.html this will redirect you to Swagger UI where you can test the service.
 3. Select the authorization controller header
 4. **Login functionality**
* Select **login** POST method and click try it out
* Then enter these **correct** username and password credentials as follows:

```
{
  "username": "Virat",
  "password": "King@18"
}
```

* Then hit execute and you will see a JWT Token generated. Copy this token to be used in the next step.
* For these **incorrect** credentials:  

 ```
{
  "username": "Virat",
  "password": "Kohli@18"
}
 ``` 
 
 **Response**

```
 {
     "title": "Not Found",
    "status": 404,
}


Token Will get Expired After Certain Time
