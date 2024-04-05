# Conductor OSS C# SDK

Conductor C# SDK for working with https://github.com/conductor-oss/conductor.

[Conductor](https://www.conductor-oss.org/) is the leading open-source orchestration platform allowing developers to build highly scalable distributed applications.

Check out the [official documentation for Conductor](https://orkes.io/content).

## ⭐ Conductor OSS

Show support for the Conductor OSS.  Please help spread the awareness by starring Conductor repo.

[![GitHub stars](https://img.shields.io/github/stars/conductor-oss/conductor.svg?style=social&label=Star&maxAge=)](https://GitHub.com/conductor-oss/conductor/)

## Content

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
<!-- END doctoc generated TOC please keep comment here to allow auto update -->

- [Set Up Conductor C# Package](#set-up-conductor-c-package)
- [Hello World Application Using Conductor](#hello-world-application-using-conductor)
  - [Step 1: Create Workflow](#step-1-create-workflow)
    - [Creating Workflows by Code](#creating-workflows-by-code)
    - [(Alternatively) Creating Workflows in JSON](#alternatively-creating-workflows-in-json)
  - [Step 2: Write Task Worker](#step-2-write-task-worker)
  - [Step 3: Write _Hello_ World Application](#step-3-write-_hello_-world-application)
- [Running Workflows on Conductor Standalone (Installed Locally)](#running-workflows-on-conductor-standalone-installed-locally)
  - [Setup Environment Variable](#setup-environment-variable)
  - [Start Conductor Server](#start-conductor-server)
  - [Execute Hello World Application](#execute-hello-world-application)
- [Running Workflows on Orkes Conductor](#running-workflows-on-orkes-conductor)
- [Learn More about Conductor C# SDK](#learn-more-about-conductor-c-sdk)
  - [[Create and Run Conductor Workers]](#create-and-run-conductor-workers)
  - [[Create Conductor Workflows]](#create-conductor-workflows)
  - [[Using Conductor in your Application]](#using-conductor-in-your-application)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->
   
## Set Up Conductor C# Package

Install Conductor C# to the project:

```shell
dotnet add package conductor-csharp
```

## Hello World Application Using Conductor

In this section, we will create a simple "Hello World" application that executes a "greetings" workflow managed by Conductor.

### Step 1: Create Workflow

#### Creating Workflows by Code

Create [greetings_workflow.cs] with the following:

```cs
To Do
```

#### (Alternatively) Creating Workflows in JSON

Create `greetings_workflow.json` with the following:

```json
{
  "name": "greetings",
  "description": "Sample greetings workflow",
  "version": 1,
  "tasks": [
    {
      "name": "greet",
      "taskReferenceName": "greet_ref",
      "type": "SIMPLE",
      "inputParameters": {
        "name": "${workflow.input.name}"
      }
    }
  ],
  "timeoutPolicy": "TIME_OUT_WF",
  "timeoutSeconds": 60
}
```

Workflows must be registered to the Conductor server. Use the API to register the greetings workflow from the JSON file above:

```cs
To Do
```

>[!note]
> To use the Conductor API, the Conductor server must be up and running (see [Running over Conductor standalone (installed locally)]).

### Step 2: Write Task Worker

Create [greetings_worker.cs] file as illustrated below:

>[!note]
>A single workflow can have task workers written in different languages and deployed anywhere, making your workflow polyglot and distributed!

```cs
To Do
```

Now, we are ready to write our main application, which will execute our workflow.

### Step 3: Write _Hello_ World Application

Let's add [helloworld.cs] with a `main` method:

```cs
To Do
```

## Running Workflows on Conductor Standalone (Installed Locally)

### Setup Environment Variable

Set the following environment variable to point the SDK to the Conductor Server API endpoint:

```shell
export CONDUCTOR_SERVER_URL=http://localhost:8080/api
```

### Start Conductor Server

To start the Conductor server in a standalone mode from a Docker image, type the command below:

```shell
docker run --init -p 8080:8080 -p 5000:5000 conductoross/conductor-standalone:3.15.0
```

To ensure the server has started successfully, open Conductor UI on http://localhost:5000.

### Execute Hello World Application

To run the application, type the following command:

```cs
To Do
```

Now, the workflow is executed, and its execution status can be viewed from Conductor UI (http://localhost:5000).

Navigate to the **Executions** tab to view the workflow execution.

Open the Workbench tab and try running the 'greetings' workflow. You will notice that the workflow execution fails. This is because the task_handler.stop_processes() [helloworld.cs] function is called and stops all workers included in the app, and therefore, there is no worker up and running to execute the tasks.

Now, let's update the app `helloworld.cs`:

```cs
To Do
```

By commenting the lines that execute the workflow and stop the task polling mechanism, we can re-run the app and run the workflow from the Conductor UI. The task is executed successfully.

## Running Workflows on Orkes Conductor

For running the workflow in Orkes Conductor,

- Update the Conductor server URL to your cluster name.

```shell
export CONDUCTOR_SERVER_URL=https://[cluster-name].orkesconductor.io/api
```

If you want to run the workflow on the Orkes Conductor Playground, set the Conductor Server variable as follows:

```shell
export CONDUCTOR_SERVER_URL=https://play.orkes.io/api
```

- Orkes Conductor requires authentication. [Obtain the key and secret from the Conductor server](https://orkes.io/content/how-to-videos/access-key-and-secret) and set the following environment variables.

```cs
export CONDUCTOR_AUTH_KEY=your_key
export CONDUCTOR_AUTH_SECRET=your_key_secret
```

Run the application and view the execution status from Conductor's UI Console.

>[!note]
>That's it - you just created and executed your first distributed C# app!

## Learn More about Conductor C# SDK

There are three main ways you can use Conductor when building durable, resilient, distributed applications.

1. Write service workers that implement business logic to accomplish a specific goal - such as initiating payment transfer, getting user information from the database, etc.
2. Create Conductor workflows that implement application state - A typical workflow implements the saga pattern.
3. Use Conductor SDK and APIs to manage workflows from your application.

### [Create and Run Conductor Workers](docs/readme/workers.md)

### [Create Conductor Workflows]

### [Using Conductor in your Application]