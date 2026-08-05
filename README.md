# 🕹️ PONG KNIGHT
### Desenvolvido na Unity Engine

> *Um jogo inspirado no clássico pong do anos 70. Pong Knight é uma mistura de dois jogos famosos sendo totalmente imerso no mundo de Hollow Knight.*

---

## 📸 Demonstração do Projeto

| Tela de Gameplay | Interface / UI |
|
| <img width="1604" height="827" alt="image" src="https://github.com/user-attachments/assets/e1b8a2ed-cc69-4edf-86a0-d92e37084509" />

---

## 🛠️ Informações Técnicas

* **Engine:** Unity (Versão 2022.3 LTS ou superior)
* **Linguagem:** C#
* **Plataforma Target:** PC / Windows
* **IDE Recomendada:** Visual Studio 2022

---

## 👥 Equipe e Divisão de Papéis

| Integrante | Função Principal | Branch de Trabalho |
!! jogo feito somente por uma pessoa !!
| **Yzabelly** | Programador de Gameplay | `feature-jogador` |
| **Yzabelly** | Programador de Obstáculos | `feature-obstaculos` |
| **Yzabelly** | UI e Designer de Interface | `feature-interface` |

---

## 🚀 Mecânicas e Funcionalidades

### Já Implementadas:
- [x] Detecção de colisão com tag `Obstacle`.
- [x] Menu inicial de início de jogo.
- [x] Efeitos sonoros de colisão.

### Em Desenvolvimento:
- [ ] Sistema de power-ups de velocidade.
- [ ] Tela de *Game Over* e pontuação por tempo.

---

## ⚙️ Contratos do Projeto (Tags & Rigidbody)

Para garantir que o projeto modular funcione ao unir as branches, a equipe deve respeitar os seguintes contratos:

* **Tags Obrigatórias:**
  * `Player`: Aplicada exclusivamente no prefab do jogador.
  * `Obstacle`: Aplicada nos prefabs de bolas e obstáculos.
* **Componentes Exigidos:**
  * O jogador **deve** possuir um `Rigidbody` com *Freeze Rotation X, Y e Z* ativados.

---

## 💻 Trecho de Código em Destaque

> Exemplo da lógica principal de detecção de impacto utilizada pelo grupo:

```csharp
private void OnCollisionEnter(Collision collision)
{
    // Validação do contrato de colisão com o obstáculo
    if (collision.gameObject.CompareTag("Obstacle"))
    {
        Debug.Log("O Jogador foi atingido!");
        Destroy(gameObject);
    }
}
```

---

## 🤝 Regras de Versionamento do Estúdio (Git / GitHub)

1. **A Branch `main` é Estável:** Nunca programe direto na `main`. Crie uma branch própria para sua tarefa.
2. **Commits Frequentes:** Faça *Commit* a cada pequena alteração concluída e testada.
3. **Mensagens de Commit Claras:** Proibido utilizar mensagens como `"arrumei"` ou `"testes"`. Use verbos no passado e seja específico (ex: `Ajustada a velocidade da bola`).
4. **Resolução de Conflitos:** Em caso de *Merge Conflict*, contate o integrante responsável pela linha conflitante antes de salvar.

---

## 📥 Como Rodar o Projeto Localmente

1. Certifique-se de ter o **Unity Hub** e a versão correta da Unity instalados.
2. Clone este repositório no seu computador usando o **GitHub Desktop**:
   ```bash
   https://github.com/usuario/nome-do-repositorio.git
   ```
3. No Unity Hub, clique em **Open** e selecione a pasta onde o projeto foi clonado.
4. Abra a cena principal localizada em `Assets/Scenes/MainScene.unity`.
