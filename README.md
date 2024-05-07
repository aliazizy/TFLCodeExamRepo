# TfL Coding Challenge
## Overview of API

TfL maintains an open data REST API at https://api.tfl.gov.uk 

In order to use it you will need to register for a developer key here: https://api-portal.tfl.gov.uk/ 

Amongst the data available is the status of major roads. Some examples of this are shown below.

Example 1: Valid Road 

To get the status of the A2 (a major road in East London) you would make an HTTP GET request to https://api.tfl.gov.uk/Road/A2?app_id=your_app_id&app_key=your_developer_key
(where ‘your_app_id’ and ‘your_developer_key’ are the values sent to you by TfL when you register as a developer).

This call will return a ‘200’ response code along with the following JSON: -

[
  {
    "$type": "Tfl.Api.Presentation.Entities.RoadCorridor, Tfl.Api.Presentation.Entities",
    "id": "a2",
    "displayName": "A2",
    "statusSeverity": "Good",
    "statusSeverityDescription": "No Exceptional Delays",
    "bounds": "[[-0.0857,51.44091],[0.17118,51.49438]]",
    "envelope": "[[-0.0857,51.44091],[-0.0857,51.49438],[0.17118,51.49438],[0.17118,51.44091],[-0.0857,51.44091]]",
    "url": "/Road/a2"
  }
]

Example 2: Non-existent road

If you made a HTTP GET request to call to https://api.tfl.gov.uk/Road/A233?app_id=your_app_id&app_key=your_developer_key

You call will return a ‘404’ response code the following response: -

{
  "$type": "Tfl.Api.Presentation.Entities.ApiError, Tfl.Api.Presentation.Entities",
  "timestampUtc": "2017-11-21T14:37:39.7206118Z",
  "exceptionType": "EntityNotFoundException",
  "httpStatusCode": 404,
  "httpStatus": "NotFound",
  "relativeUri": "/Road/A233",
  "message": "The following road id is not recognised: A233"
}


#	How to build the code
Clone the repo to your local PC and then open the solution (TFLWebApiClient.sln) on the visual studio 2022, select Release from the header and under the build menue select Rebuild Solution.
#	How to run the output
Open CMD on Windows and navigate to the \TFLWebApiClient\bin\Release\net8.0 and run TFLWebApiClient.exe with a roadId for example TFLWebApiClient.exe A2
#	How to run any tests that you have written
Clone the repo to your local PC and then open the solution (TFLWebApiClient.sln) on the visual studio 2022, on the top  menue under the Test select Run All Test.
#	any assumptions that you’ve made
- Using Visual studio 2022.
- using .net8.0
