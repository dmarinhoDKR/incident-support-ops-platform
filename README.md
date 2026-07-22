## Tech Stack

![C#](https://img.shields.io/badge/C%23-0F172A?style=flat-square&logo=csharp&logoColor=9B4F96)
![.NET](https://img.shields.io/badge/.NET-0F172A?style=flat-square&logo=dotnet&logoColor=512BD4)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-0F172A?style=flat-square&logo=dotnet&logoColor=512BD4)
![REST API](https://img.shields.io/badge/REST%20API-0F172A?style=flat-square&logo=swagger&logoColor=85EA2D)
![Swagger](https://img.shields.io/badge/Swagger%20%2F%20OpenAPI-0F172A?style=flat-square&logo=swagger&logoColor=85EA2D)

**Focus:** incident management, ticket triage, SLA monitoring, and operational support workflows.

# Incident Support Ops Platform

Support-focused portfolio project built with ASP.NET Core Web API.

## Overview

This project simulates an incident and support operations platform, designed to strengthen backend, QA, support, troubleshooting, and product-oriented skills.

At this stage, the API already provides:

- health check endpoint
- Swagger documentation
- incident listing endpoint
- incident lookup by ID

## Tech Stack

- C#
- ASP.NET Core Web API
- Swagger / OpenAPI
- Git and GitHub
- WSL + VS Code

## Current Endpoints

- `GET /`
- `GET /health`
- `GET /api/incidents`
- `GET /api/incidents/{id}`

## Project Goal

The long-term goal of this project is to evolve into a more complete incident and support platform with:

- incident creation and status updates
- comments and history
- C++ log analyzer service
- Docker and Docker Compose
- Playwright tests
- BDD with Cucumber
- Kubernetes manifests
- cloud-oriented deployment structure

## Running Locally

```bash
dotnet run --project src/IncidentOps.Api
