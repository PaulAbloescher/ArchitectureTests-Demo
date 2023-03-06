% Architecture Testing
% Paul-Noel Abloescher
% March 07, 2023

## Contents

- [Why?](#why)
- [How?](#how)
- [When not to use?](#when-not-to-use)
- [Available libraries](#available-libraries)
- [Example usecase: Clean Architecture](#example-usecase-clean-architecture)
- [Available rules](#available-rules)
- [Example](#example)

## Why?

- Retain software architecture
- Avoid the "dependency hell"
- Spread knowledge by executable rules
- Different experience levels among devs

## How?
- Dotnet => Unit Tests that check specified rules (feedback through failing tests)
- Angular nx (build system) => module boundary linting rules (instant feedback)

## When not to use?
- Usefulness depends on the context
- Can be hard to add afterwards (legacy applications, ...)
- Some architectures may be hard to test => vertical slice architecture

## Available libraries
- Compatible with .NET Framework, .NET Core & .NET 5+
    - [ArchUnitNet](https://archunitnet.readthedocs.io/en/latest/)
    - [NetArchTest](https://github.com/BenMorris/NetArchTest)

## Example usecase: Clean Architecture

![Clean Architecture](Images/CleanArchitecture.jpg)

## Available rules

[Documentation](https://archunitnet.readthedocs.io/en/latest/guide/#3-what-to-check)

## Example