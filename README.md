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
