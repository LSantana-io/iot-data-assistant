# 📝 IoT Data Scraper (Python + Playwright)

[![Dotnet](https://img.shields.io/badge/Framework%20version-dotnet%209-blue)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
[![Playwright](https://img.shields.io/badge/framework-Playwright-green.svg)](https://playwright.dev/python/)
[![Architecture](https://img.shields.io/badge/design-Page%20Object%20Model-orange.svg)]()

Automação robusta para extração de dados históricos de plataformas IoT. Este projeto utiliza o padrão **Page Object Model (POM)** para garantir que o código seja limpo, fácil de manter e pronto para uma futura migração para **C#** ou **Java**.

---

## 🚀 Fluxo de Navegação
O scraper foi projetado para seguir este fluxo lógico:
1. **Autenticação:** Login automático utilizando credenciais seguras.
2. **Navegação:** Acesso direto ao módulo de exportação da plataforma.
3. **Seleção de Parâmetros:** Escolha dinâmica entre "Consumo" ou "Temperatura".
4. **Intervalo Temporal:** Seleção inteligente de um intervalo de 7 dias no calendário (DOM).
5. **Monitoramento:** Espera ativa pelo processamento dos dados (Pooling/Wait for State).
6. **Captura:** Download do arquivo CSV diretamente para a memória (BytesIO).

---

## 🏗️ Estrutura do Projeto
A organização de pastas foi pensada para separação de responsabilidades:

```text
iot_scraper/
├── config/             # Configurações de ambiente e constantes
├── logs/               # Registros de execução e screenshots de erro
├── src/
│   ├── core/           # Fábrica de navegadores (Browser Factory)
│   ├── pages/          # Classes POM (BasePage, LoginPage, ExportPage)
│   └── services/       # Processamento de dados e lógica de negócio
├── tests/              # Testes automatizados (Pytest)
├── main.py             # Orquestrador 
├── .env                # Credenciais 
└── requirements.txt    # Dependências do projeto
