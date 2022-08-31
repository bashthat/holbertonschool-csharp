#!/usr/bin/env bash
# creating the new project
dotnet new project -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project
