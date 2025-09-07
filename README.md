The project uses Entity Framework Core Code-First.
Two test users are seeded for login:
userA@example.com password: 123
userB@example.com password: 789
**************************************************
Configuration

Before running the project, update the appsettings.json files:

WebAPI → set the correct ConnectionStrings:defaultconn and adjust JWTSettings (ValidIssuer, ValidAudience, SecurityKey) if needed.

UI → update MyApiSettings:BaseUrl to point to your running WebAPI host (e.g. https://localhost:7191/).

These host/URL values must match between UI and API for authentication to work.
