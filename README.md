# Azure DevOps Demo
This project is created to demonstrate the development of full CI/CD Pipeline Using Azure DevOps.

Code Repo: GitHub.
CI/CD: Azure DevOps.
Target Server: Windows Server 2019 VM on Azure.

This GitHub Repo contains 
  1. A Website Project to demonstrate the deployment of a basic .Net Core MVC Web Application to Azure.
  2. An XUnit Project that contains rudimentary unit tests for the controllers.
  3. An MSTest Project that contains very basic Headless Selenium Tests that checks AbacusNext's Home Page to see if the page is loading and the footer is correct.
  
 The Unit Tests and Integration Tests are executed at the appropriate time during the CI/CD Cycle and the applicaiton is deployed to Windows Server 2019 VM on Azure after successful execution of these tests.
 