# Epic-RPG Backend API Documentation

Welcome to the Epic-RPG Backend API documentation. This API is the backbone of an RPG game and allows you to perform various actions and interactions within the game.

![Epic-RPG Logo](https://phx02pap003files.storage.live.com/y4mshUUqW6nBDGMTO-d11k3hpFn-Qyj2x7zppV2f3SKztgzEAGOrIhX9dBu-2MjGGg9Ur2ZtYoZYgnt7sZZZehHwBw3Y68qSdQv448an27ewn_Vzx7X-RKG8cwOLVUNgCanvA32_lKygeJ9pSxYH_CWBcPVVFAJwXb3KMZWRCd8FumrvOsT94cC6_CwSnyhrKrJeoRPshFVMUNdePvLzisJ6Ym0P4bLrVvInAqs6V8dWxk?encodeFailures=1&width=500&height=500)

## Table of Contents

1. [Introduction](#introduction)
2. [Getting Started](#getting-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
3. [Endpoints](#endpoints)
   - [Authentication](#authentication)
   - [Character Management](#character-management)
   - [Fight](#fight)
   - [Weapon](#weapon)
4. [Database](#database)
   - [Entities and Relationships](#entities-and-relationships)
   - [Data Seeding](#data-seeding)
5. [Authentication and Authorization](#authentication-and-authorization)
   - [JSON Web Tokens (JWT)](#json-web-tokens-jwt)
   - [User Registration](#user-registration)
   - [User Login](#user-login)
6. [Project Structure](#project-structure)
   - [Solution Overview](#solution-overview)
   - [Commit History](#commit-history)
7. [Contributing](#contributing)

## Introduction

The Epic-RPG Backend API is built using .NET 7 and C# Web API. It provides the functionality for managing user accounts, character creation and management, skills, weapons, and combat in the Epic-RPG game.

## Getting Started

### Prerequisites

- .NET 7
- Entity Framework
- SQL Server or other compatible database
- Git

### Installation

1. Clone the repository:

```bash
git clone https://github.com/hafizmp/Epic-RPG-API.git
```

2. Navigate to the project directory and set up the database connection string.

3. Run the following command to create the database and apply migrations:

```bash
dotnet ef database update
```

4. Start the API:

```bash
dotnet watch run
```

The API will be accessible at `http://localhost:5200/`

## Endpoints

### Authentication

- __POST__  `/api/Auth/Register` : User registration.
- __POST__  `/api/Auth/Login` : User login to obtain a JWT token.

### Character Management

- __GET__  `/api/Character/GetAll` : Get all characters.
- __GET__  `/api/Character/{id}` : Get a specific character.
- __DELETE__  `/api/Character/{id}` : Delete a specific character.
- __POST__  `/api/Character` : Create a new character.
- __PUT__  `/api/Character` : Update a character.
- __POST__  `/api/Character/Skill` : Manage skills for a character.

### Fight

- __POST__  `/api/Fight/Weapon` : Use a weapon during a fight.
- __POST__  `/api/Fight/Skill` : Use a skill during a fight.
- __POST__  `/api/Fight` : Begin a fight.
- __GET__  `/api/Fight` : Get information about an ongoing fight.

### Weapon

- __POST__  `/api/Weapon` : Create a new weapon.

![Epic-RPG endpoints](https://phx02pap003files.storage.live.com/y4m3oDsC4pnVebeLl1KUC671xzPidQb9iFn_yP92FbqE0ssupz93184PMmJIbol-vFeN2VvdKVgVI-wx7GwgbOSIWohmDuvpU7l3DfZ__vRafrPQLqdEbrau_1RGq6ptm9-GOUan1w30qBUM0IjR8MtGssVSt5bll42vzU615UCG-QTg_ObtGbsOrbLcQIOXj6DgQv_yaYPWe9P2n1nZuGx9PSa3WLYEjkoNJPonJBnHSc?encodeFailures=1&width=1748&height=1240)

## Database

### Entities and Relationships

The API uses Entity Framework to manage the following entities and their relationships:

- Users
- Characters
- Skills
- Weapons

### Data Seeding

The database is seeded with initial data to demonstrate the API's functionality.

## Authentication and Authorization

### JSON Web Tokens (JWT)

This API uses JWT for authentication and authorization.

### User Registration

Users can register using the `/api/Auth/Register` endpoint.

### User Login

Users can obtain an access token by logging in via the `/api/Auth/Login` endpoint.

## Project Structure

### Solution Overview

- `EpicRPG.API` : The main API project.
- `EpicRPG.Data` : Data models and Entity Framework setup.
- `EpicRPG.Services` : Business logic and services.
- `EpicRPG.Auth` : Authentication services.
- `EpicRPG.DTOs` : Data transfer objects.
- `EpicRPG.Controllers` : API controllers.

## Commit History

Here are some of the key commits that contributed to the development of the API:

- [Epic-RPG-API commits]('https://github.com/hafizmp/Epic-RPG-API/commits/main') - Find commits by clicking here.

## Contributing

Feel free to contribute to the development of Epic-RPG-API by submitting pull requests or reporting issues.
