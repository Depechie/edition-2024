﻿using System.ClientModel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using Microsoft.SemanticKernel.Connectors.Google;
using Microsoft.SemanticKernel.Connectors.MistralAI;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using OpenAI;
using OpenAI.Chat;

Console.WriteLine("Hello AI World");
Console.WriteLine("===============");

//IChatCompletionService chatService = new OpenAIChatCompletionService("gpt-4o-mini", Environment.GetEnvironmentVariable("AI:OpenAI:Key")); Console.WriteLine("Configuration : OpenAI - gpt-4o-mini");
//IChatCompletionService chatService = new GoogleAIGeminiChatCompletionService("gemini-1.5-flash-latest", Environment.GetEnvironmentVariable("AI:GoogleGemini:Key")); Console.WriteLine("Configuration : Google - gemini-1.5-flash-latest");
//IChatCompletionService chatService = new MistralAIChatCompletionService("mistral-small-mini", Environment.GetEnvironmentVariable("AI:Mistral:Key")); Console.WriteLine("Configuration : Mistral - mistral-small-mini");
IChatCompletionService chatService = new AzureOpenAIChatCompletionService("gpt-4o", "https://devday-semantickernel-test.openai.azure.com/", Environment.GetEnvironmentVariable("AI:AzureOpenAI:Key")); Console.WriteLine("Configuration : Azure OpenAI - gpt-4o");

Console.WriteLine("Q: Quel est la couleur du ciel ?");
Console.WriteLine( await chatService.GetChatMessageContentAsync("Quel est la couleur du ciel ?"));