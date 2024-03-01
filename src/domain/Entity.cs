/*
 * StartCRM – a system for managing customer relationship
 * Copyright (C) 2023  Mohammad Abdul Ahad Chowdhury
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published
 * by the Free Software Foundation, version 3 of the License.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using SurrealDb.Net.Models;
namespace StartCRM.Domain;

public class Entity : Record
{
	public Entity(Thing? createdById)
	{
		CreatedAt = DateTime.Now;
		CreatedById = createdById;
	}

	public DateTime CreatedAt { get; private set; }
	public Thing? CreatedById { get; private set; }
}
