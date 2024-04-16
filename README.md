Project:
A windows-form application with the following functionalities:
• 1: Filling Local Database
  o Filling a table in local database (SQLite) from the API-System (GET)
• 2: Clearing the Local Table
• 3: Filling a GridView directly from the API
• 4: Filling the GridView from the local database
• 5: Pagination and Search feature (Filtering) in localDB-loaded grid.
• 6: Ability to add a new record into backend database using API.

Sample:
    curl –location –request POST ‘http://tasks.cloudsite.ir/api/’
    --form ‘name=Azadeh’
    --form ‘date=2024-04-04’
    --form ‘comment=azad comment’
    
API Address: http://tasks.cloudsite.ir/api/
