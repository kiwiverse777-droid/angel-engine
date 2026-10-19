# Angel Engine — DevKit v0.1

**Status: primeira base de desenvolvimento própria, ainda não é uma engine completa.**

Este pacote começa a transformar a ideia da Angel Engine em código próprio, usando o Stride como camada aberta de renderização/3D. Ele **não** tenta vender o editor original do Stride como se fosse um produto nosso.

## O que já é nosso neste pacote
- namespace e API inicial `AngelEngine`;
- camada de cena/entidades e componentes simples;
- projeto de demonstração;
- workflow do GitHub Actions para compilar na nuvem, sem exigir que o PC de 2 GB compile o projeto;
- documentação que identifica claramente o Stride como dependência/base.

## O que ainda falta
Esta é uma fundação de código, não uma engine completa. Ainda faltam editor visual próprio, integração validada com o runtime Stride, importação/exportação de recursos, sistema de projeto e testes completos de execução. O workflow compila o projeto de demonstração usando pacotes NuGet do Stride; a compatibilidade exata depende da versão publicada dos pacotes e será confirmada pelo resultado do build.

## Estrutura
- `src/AngelEngine.Core/` — código próprio da camada de alto nível.
- `samples/AngelEngine.Demo/` — demonstração inicial.
- `.github/workflows/build-angel-engine.yml` — build em máquina Windows hospedada pelo GitHub.
- `THIRD-PARTY.md` — atribuição e lembrete de licença.

## Como usar sem sobrecarregar seu PC
1. Extraia o ZIP.
2. Envie os arquivos para o repositório `kiwiverse777-droid/angel-engine` no GitHub, mantendo as pastas.
3. Abra **Actions** e escolha **Angel Engine — Cloud Build**.
4. Clique em **Run workflow**.
5. Quando terminar, baixe o artefato `Angel-Engine-DevKit` na execução.

> Importante: um build verde confirma que os projetos deste pacote compilaram; não significa que todos os recursos de uma engine comercial estejam prontos. Se a compilação falhar, envie o log da etapa vermelha para corrigirmos a causa real.

## Base técnica
O Stride continua sendo uma dependência de código aberto separada. A Angel Engine acrescenta uma camada própria sobre ela; não afirmamos ser autores do código upstream. Leia `THIRD-PARTY.md` e a licença aplicável antes de redistribuir builds.
