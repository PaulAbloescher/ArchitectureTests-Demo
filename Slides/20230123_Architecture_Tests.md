% Architecture Testing
% Paul-Noel Abloescher
% February 07, 2023

## Contents

- [Example: Clean Architecture](#example-clean-architecture)
- [Why?](#why)
- [How?](#how)
- [When not to use?](#when-not-to-use)
- [Available rules](#available-rules)
- [Example](#example)

## Example usecase: Clean Architecture

![Clean Architecture](Images/CleanArchitecture.jpg)

## Why?

- Retain software architecture
- Avoid the "dependency hell"
- Spread knowledge by executable rules
- Different experience levels among devs

## How?
- Dotnet => Unit Tests that check specified rules (feedback through failing tests)
- Angular nx => module boundary linting rules (instant feedback)

## Availability
- Compatible with .NET Framework, .NET Core & .NET 5+
    - [ArchUnitNet](https://archunitnet.readthedocs.io/en/latest/)
    - [NetArchTest](https://github.com/BenMorris/NetArchTest)

## When not to use?
- Usefulness depends on the context
- May be hard to add to legacy projects
- Some architectures may be hard to test => vertical slice architecture
- No silver bullet

## Available rules

[Documentation](https://archunitnet.readthedocs.io/en/latest/guide/#3-what-to-check)

## Example