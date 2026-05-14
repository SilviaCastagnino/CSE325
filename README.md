# CSE 325: .NET Software Development - Week 01 Assignment

This repository contains the completed assignment artifacts for Week 01, based on the Microsoft Learn paths for .NET 8 LTS. It includes a RESTful Web API with custom CRUD test evidence and a file processing utility with an automated sales report generator.

---

## Project 1: Web API with ASP.NET Core Controllers

### Location
`week01/ContosoPizza/`

### Description
A RESTful web API built with ASP.NET Core that demonstrates full CRUD (Create, Read, Update, Delete) operations using controllers and an in-memory data service. 

As required by the assignment, an **additional initial record** was appended to the base Pizza list in `PizzaService.cs`.

### CRUD Operation Evidence & Status Codes

#### 1. POST - Create a new Pizza (Hawaii)
**Request:**
POST {{ContosoPizza_HostAddress}}/pizza/
Content-Type: application/json

{
    "name": "Hawaii",
    "isGlutenFree": false
}

**Response:**
{
  "id": 3,
  "name": "Hawaii",
  "isGlutenFree": false
}
#### 2. PUT - Update the newly created Pizza
**Request:**
PUT {{ContosoPizza_HostAddress}}/pizza/7
Content-Type: application/json

{
    "id": 3,
    "name": "Hawaiian",
    "isGlutenFree": false
}

**Response:**
(The update was successful and the resource was modified)

#### 3. GET - Verify the Update by ID
**Request:**
GET {{ContosoPizza_HostAddress}}/pizza/3
Accept: application/json

**Response:**
{
  "id": 3,
  "name": "Hawaiian",
  "isGlutenFree": false
}

#### 4. DELETE - Remove the Pizza
**Request:**
DELETE {{ContosoPizza_HostAddress}}/pizza/3

**Response:**
(The resource was successfully deleted from the in-memory cache)

#### 5. GET - Final check of the Pizza List
**Request:**
GET {{ContosoPizza_HostAddress}}/pizza/
Accept: application/json

**Response:**
[
  {
    "id": 1,
    "name": "Classic Italian",
    "isGlutenFree": false
  },
  {
    "id": 2,
    "name": "Veggie",
    "isGlutenFree": true
  }
]


## Project 2: Sales Summary
### Location
`week01/mslearn-dotnet-files/`

### Description
The code generates a sales summary report file. The file shows the actual total sales and a detail report of each sale.

### Expected Output Format from Working Sales Summary Function Code

Sales Summary
----------------------------
 Total Sales: $2,012.20

 Details:
 
  sales.json: $88.88

  sales.json: $501.22

  salestotals.json: $0.00

  sales.json: $1,234.22

  salestotals.json: $0.00

  sales.json: $99.00

  salestotals.json: $0.00

  sales.json: $88.88

  salestotals.json: $0.00