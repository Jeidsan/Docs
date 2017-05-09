using Docs.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Docs.Domain.Base
{
    /// <summary>
    /// Descreve as funcionalidades mínimas exigida para que um processo se cadastre no sistema.
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// Processa uma solicitação de acesso a um recurso da rede.
        /// </summary>
        /// <param name="idProcesso">Identificador do processo requerente.</param>
        /// <param name="idRecurso">Identificador do recurso requisitado.</param>
        /// <param name="tempo">Tempo do processo requerente.</param>
        /// <returns>Status de acesso ao recurso requisitado.</returns>
        ResourceStatus GetRecurso(Guid idProcesso, Guid idRecurso, int tempo);

        /// <summary>
        /// Inicia a execução do processo na rede.
        /// </summary>
        void Start();
    }
}
