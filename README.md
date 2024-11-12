# HotelBooking

Este projeto é uma API para gerenciar reservas em um sistema de hospedagem, com funcionalidades para manipulação de dados de hóspedes, reservas e pagamentos.

## Funcionalidades

- *Gerenciamento de Hóspedes*: Adicionar, atualizar, buscar e deletar informações de hóspedes.
- *Gerenciamento de Reservas*: Criar e gerenciar reservas para quartos de hotel.
- *Processamento de Pagamento*: Simulação e manipulação de pagamentos para as reservas realizadas.

## Estrutura do Projeto

- BookingService: Serviço responsável pela lógica de reservas.
- PaymentService: Serviço dedicado ao processamento de pagamentos.
- ApplicationTest: Módulo de testes para validar as funcionalidades principais.

## Pré-requisitos

- .NET Core SDK
- Visual Studio ou outro editor compatível

## Instalação

1. Atualizar EF:
	dotnet tool update --global dotnet-ef --version 3.1.0

2. Atualizar Tabelas:
	dotnet ef database update (cd BookingService\Consumers\API>)

3. Rodar Swagger:
	dotnet watch --project .\BookingService\Consumers\API\
