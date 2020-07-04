# Project Variables
PROJECT_NAME ?= salessystem
ORG_NAME ?= salessystem
REPO_NAME ?= salessystem

.PHONY: migrations db

migrations:
	cd ./salessystem.Data && dotnet ef --startup-project ../salessystem.Web/ migrations add $(mname) && cd ..

db:
	cd ./salessystem.Data && dotnet ef --startup-project ../salessystem.Web/ database update && cd ..
